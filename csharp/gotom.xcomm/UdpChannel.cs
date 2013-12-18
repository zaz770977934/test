using System;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;
/**
 * 
 * 模块：通道基类
 * 
 * 功能：Udp通道
 * 
 * 作者：裴绍国
 * 
 * 时间：2012-11-27
 * 
 * 
 */
namespace gotom.xcomm
{
    /// <summary>
    /// Udp通道
    /// </summary>
    public class UdpChannel : Channel
    {

        protected UdpClient udpClient { get; set; }

        protected UdpClient udpSend { get; set; }

        protected IPEndPoint RemotePoint { get; set; }

        protected IPEndPoint LocalPoint = new IPEndPoint(IPAddress.Any, 8000);

        public UdpChannel(int localPort, string remoteIp, int remotePort)
        {
            RemotePoint = new IPEndPoint(IPAddress.Parse(remoteIp), remotePort);
            LocalPoint = new IPEndPoint(IPAddress.Any, localPort);
            this.Id = LocalPoint.ToString() + "-" + RemotePoint.ToString();
        }

        public override void Write(byte[] buffer)
        {
            try
            {
                udpSend.Send(buffer, buffer.Length, RemotePoint);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                UdpClient receive = (UdpClient)ar.AsyncState;
                byte[] buffer = receive.EndReceive(ar, ref LocalPoint);
                this.OnReceiveHandler(buffer);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("UDP通道[" + Id + "]" + ex.Message);
            }
            finally
            {
                try
                {
                    udpClient.BeginReceive(ReceiveCallback, udpClient);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("UDP通道[" + Id + "]" + ex.Message);
                }
            }
        }

        public override void Close()
        {
            if (udpClient != null)
            {
                udpClient.Close();
            }
            udpClient = null;
            if (udpSend != null)
            {
                udpSend.Close();
            }
            udpSend = null;
            this.OnStateHandler(ChannelState.Close);
            //Debug("UDP通道[" + Id + "]已经关闭");
        }

        public override void Connect()
        {
            try
            {
                if (!this.Connected())
                {
                    OnStateHandler(ChannelState.Connecting);
                    Close();
                    udpSend = new UdpClient();
                    udpClient = new UdpClient(LocalPoint.Port);
                    Debug.WriteLine("UDP通道[" + Id + "]开始接收数据");
                    OnStateHandler(ChannelState.Connected);
                    udpClient.BeginReceive(ReceiveCallback, udpClient);                    
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
    }
}
