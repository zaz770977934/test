using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;
using System.IO;

namespace gotom.xcomm
{
    public class TcpChannel : Channel
    {
        protected TcpClient Client { get; set; }

        protected IPEndPoint EndPoint { get; set; }

        protected Stream Stream { get; set; }

        public TcpChannel(string ip, int port)
        {
            try
            {
                EndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
                this.Id = EndPoint.ToString();
            }
            catch (Exception ex)
            {
                this.Id = ip + ":" + port;
                Debug.WriteLine(ex.Message);
            }
        }

        public override void Connect()
        {
            try
            {
                if (!Connected())
                {
                    OnStateHandler(ChannelState.Connecting);
                    Client = new TcpClient();
                    Debug.WriteLine("TCP通道开始连接[" + Id + "]");
                    Client.Connect(EndPoint);
                    Debug.WriteLine("TCP通道连接成功[" + Id + "]");
                    OnStateHandler(ChannelState.Connected);
                    BeginRead(Client.GetStream());
                }
                else
                {
                    Debug.WriteLine("UDP通道已经连接[" + Id + "]");
                    OnStateHandler(ChannelState.Connected);
                }
            }
            catch (Exception ex)
            {
                OnStateHandler(ChannelState.Failed);
                Debug.WriteLine("UDP通道连接异常[" + Id + "]：" + ex.Message);
                throw ex;
            }
        }

        public override void Close()
        {
            if (Client != null)
            {
                Client.Close();
            }
            OnStateHandler(ChannelState.Close);
        }

        public override void Write(byte[] bytes)
        {
            Stream.Write(bytes, 0, bytes.Length);
        }

        #region 接收数据

        /// <summary>
        /// 接收队列
        /// </summary>
        protected byte[] ReceiveBuffer = new byte[115200];

        protected void BeginRead(Stream stream)
        {
            this.Stream = stream;
            Debug.WriteLine("异步开始接收数据[" + Id + "]");
            Stream.BeginRead(this.ReceiveBuffer, 0, this.ReceiveBuffer.Length, new AsyncCallback(this.ReceiveCallback), Stream);
        }

        /// <summary>
        /// 异步接收
        /// </summary>
        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                Stream asyncState = (Stream)ar.AsyncState;
                int size = asyncState.EndRead(ar);
                if (size > 0)
                {
                    byte[] buffer = new byte[size];
                    Array.Copy(ReceiveBuffer, 0, buffer, 0, size);
                    Debug.WriteLine("异步接收数据完成![" + Id + "]接收字节数：" + size);
                    OnReceiveHandler(buffer);
                    asyncState.BeginRead(this.ReceiveBuffer, 0, this.ReceiveBuffer.Length, new AsyncCallback(this.ReceiveCallback), asyncState);
                }
                else
                {
                    Debug.WriteLine(" ***** 异步接收回调退出[" + Id + "] ***** ");
                    OnStateHandler(ChannelState.Disconnect);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("异步接收异常[" + Id + "]：" + ex.Message);
                OnStateHandler(ChannelState.Disconnect);
            }
        }

        #endregion
    }
}
