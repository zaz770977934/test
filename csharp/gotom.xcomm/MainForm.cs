using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Globalization;

namespace gotom.xcomm
{
    public partial class MainForm : Form
    {
        private IChannel Channel { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnConn.Text.Equals("连接"))
                {
                    if (Channel!= null)
                    {
                        Channel.Close();
                    }
                    Channel = null;
                    switch (tabControl.SelectedIndex)
                    {
                        case 0:
                            Channel = new TcpChannel(tcpIP.Text, int.Parse(tcpPort.Text));
                            break;
                        case 1:
                            Channel = new UdpChannel(int.Parse(this.udpLocalPort.Text), udpIp.Text, int.Parse(udpPort.Text));
                            break;
                        case 2:
                            Channel = new SerialChannel(this.SerialName.Text, int.Parse(SerialBaudRate.Text), int.Parse(DataBits.Text), (StopBits)comboBoxStopBits.SelectedItem, (Parity)comboBoxParity.SelectedItem);
                            break;
                    }
                    if (Channel != null)
                    {
                        Channel.Connect();
                        Channel.ReceiveHandler += new CommonHandler<byte[]>(Channel_ReceiveHandler);
                        Channel.StateHandler += new CommonHandler<ChannelState>(Channel_StateHandler);
                        btnConn.Text = "关闭";
                    }
                }
                else
                {
                    btnConn.Text = "连接";
                    if (Channel!= null)
                    {
                        Channel.ReceiveHandler -= new CommonHandler<byte[]>(Channel_ReceiveHandler);
                        Channel.StateHandler -= new CommonHandler<ChannelState>(Channel_StateHandler);
                        Channel.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Channel_StateHandler(object sender, CommonEventArgs<ChannelState> e)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    CommonHandler<ChannelState> d = new CommonHandler<ChannelState>(Channel_StateHandler);
                    this.Invoke(d, new object[] { sender, e });
                }
                else
                {
                    if (e.Result == ChannelState.Connected || e.Result == ChannelState.Connecting)
                    {

                    }
                    else
                    {
                        MessageBox.Show(e.Result.ToString());
                    }
                }
            }
            catch { } 

        }

        void Channel_ReceiveHandler(object sender, CommonEventArgs<byte[]> e)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    CommonHandler<byte[]> d = new CommonHandler<byte[]>(Channel_ReceiveHandler);
                    this.Invoke(d, new object[] { sender, e });
                }
                else
                {
                    this.textRead.Text += (" " + BitConverter.ToString(e.Result).Replace("-", " "));
                }
            }
            catch { }            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (Channel != null)
                {
                    string[] buffer = this.textSend.Text.Split(' ');
                    List<byte> bytes = new List<byte>();
                    foreach (string bs in buffer)
                    {
                        bytes.Add((byte)int.Parse(bs, NumberStyles.HexNumber));
                    }
                    Channel.Write(bytes.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.SerialName.Items.AddRange(SerialPort.GetPortNames());
            this.comboBoxStopBits.Items.AddRange(new object[] { StopBits.One, StopBits.OnePointFive, StopBits.Two });
            this.comboBoxParity.Items.AddRange(new object[] { Parity.None, Parity.Mark, Parity.Odd, Parity.Even, Parity.Space });
            if (SerialName.Items.Count > 0)
                SerialName.SelectedIndex = 0;
            if (comboBoxStopBits.Items.Count > 0)
                comboBoxStopBits.SelectedIndex = 0;
            if (comboBoxParity.Items.Count > 0)
                comboBoxParity.SelectedIndex = 0;
            SerialBaudRate.SelectedItem = "115200";
            DataBits.SelectedItem = "8";
        }
    }
}
