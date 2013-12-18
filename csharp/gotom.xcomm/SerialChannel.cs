using System;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;
/**
 * 
 * 模块：通道基类
 * 
 * 功能：串口通道
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
    /// 串口通道
    /// </summary>
    public class SerialChannel : Channel
    {
        /// <summary>
        /// 串口
        /// </summary>
        private SerialPort Sp { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public SerialChannel(string PortName)
            : this(PortName, 115200, 8, StopBits.One,Parity.None)
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public SerialChannel(string PortName, int BaudRate, int DataBits, StopBits StopBits, Parity Parity)
            : this(PortName, BaudRate, DataBits, StopBits, Parity, false, false)
        {
            
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public SerialChannel(string PortName, int BaudRate, int DataBits, StopBits StopBits, Parity Parity, bool DtrEnable, bool RtsEnable)
            : base()
        {
            Sp = new SerialPort();
            this.Id = Sp.PortName = PortName;
            Sp.BaudRate = BaudRate;
            Sp.DataBits = DataBits;
            Sp.StopBits = StopBits;
            Sp.Parity = Parity;
            Sp.DtrEnable = DtrEnable;
            Sp.RtsEnable = RtsEnable;
            Sp.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);

        }

        /// <summary>
        /// Windows 读串口数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] buffer = new byte[Sp.BytesToRead];
            Sp.Read(buffer, 0, buffer.Length);
            this.OnReceiveHandler(buffer);
        }

        /// <summary>
        /// 关闭
        /// </summary>
        public override void Close()
        {
            
            if (Sp != null)
            {
                if (Sp.IsOpen)
                {
                    Debug.WriteLine("通道[" + Id + "]关闭");
                }
                Sp.Close();
                Sp.Dispose();
            }
            this.OnStateHandler(ChannelState.Close);
        }

        /// <summary>
        /// 发送数
        /// </summary>
        /// <param name="buffer"></param>
        public override void Write(byte[] buffer)
        {
            Sp.Write(buffer, 0, buffer.Length);
        }

        public override void Connect()
        {
            try
            {
                if (!Sp.IsOpen)
                {
                    this.OnStateHandler(ChannelState.Connecting);
                    Sp.Open();
                    Thread.Sleep(30);
                    Debug.WriteLine("通道连接[" + Id + "]成功");
                }
                OnStateHandler(ChannelState.Connected);
            }
            catch (Exception ex)
            {
                OnStateHandler(ChannelState.Failed);
                Debug.WriteLine("通道连接异常[" + Id + "]：" + ex.Message);
                throw ex;
            }
        }
    }

}
