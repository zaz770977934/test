namespace gotom.xcomm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.TCP = new System.Windows.Forms.TabPage();
            this.UDP = new System.Windows.Forms.TabPage();
            this.btnConn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textSend = new System.Windows.Forms.TextBox();
            this.textRead = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SP = new System.Windows.Forms.TabPage();
            this.tcpIP = new System.Windows.Forms.TextBox();
            this.tcpPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.udpPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.udpIp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.udpLocalPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SerialBaudRate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SerialName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.DataBits = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.TCP.SuspendLayout();
            this.UDP.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SP.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.TCP);
            this.tabControl.Controls.Add(this.UDP);
            this.tabControl.Controls.Add(this.SP);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(811, 61);
            this.tabControl.TabIndex = 0;
            // 
            // TCP
            // 
            this.TCP.Controls.Add(this.tcpPort);
            this.TCP.Controls.Add(this.label2);
            this.TCP.Controls.Add(this.tcpIP);
            this.TCP.Controls.Add(this.label1);
            this.TCP.Location = new System.Drawing.Point(4, 21);
            this.TCP.Name = "TCP";
            this.TCP.Padding = new System.Windows.Forms.Padding(3);
            this.TCP.Size = new System.Drawing.Size(618, 36);
            this.TCP.TabIndex = 0;
            this.TCP.Text = "TCP";
            this.TCP.UseVisualStyleBackColor = true;
            // 
            // UDP
            // 
            this.UDP.Controls.Add(this.udpLocalPort);
            this.UDP.Controls.Add(this.label5);
            this.UDP.Controls.Add(this.udpPort);
            this.UDP.Controls.Add(this.label3);
            this.UDP.Controls.Add(this.udpIp);
            this.UDP.Controls.Add(this.label4);
            this.UDP.Location = new System.Drawing.Point(4, 21);
            this.UDP.Name = "UDP";
            this.UDP.Padding = new System.Windows.Forms.Padding(3);
            this.UDP.Size = new System.Drawing.Size(803, 36);
            this.UDP.TabIndex = 1;
            this.UDP.Text = "UDP";
            this.UDP.UseVisualStyleBackColor = true;
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(4, 63);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(75, 23);
            this.btnConn.TabIndex = 1;
            this.btnConn.Text = "连接";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textRead);
            this.panel1.Controls.Add(this.textSend);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 234);
            this.panel1.TabIndex = 2;
            // 
            // textSend
            // 
            this.textSend.Dock = System.Windows.Forms.DockStyle.Top;
            this.textSend.Location = new System.Drawing.Point(0, 0);
            this.textSend.Multiline = true;
            this.textSend.Name = "textSend";
            this.textSend.Size = new System.Drawing.Size(811, 96);
            this.textSend.TabIndex = 0;
            // 
            // textRead
            // 
            this.textRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textRead.Location = new System.Drawing.Point(0, 96);
            this.textRead.Multiline = true;
            this.textRead.Name = "textRead";
            this.textRead.Size = new System.Drawing.Size(811, 138);
            this.textRead.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(85, 63);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // SP
            // 
            this.SP.Controls.Add(this.comboBoxParity);
            this.SP.Controls.Add(this.DataBits);
            this.SP.Controls.Add(this.label8);
            this.SP.Controls.Add(this.comboBoxStopBits);
            this.SP.Controls.Add(this.label9);
            this.SP.Controls.Add(this.label10);
            this.SP.Controls.Add(this.SerialBaudRate);
            this.SP.Controls.Add(this.label6);
            this.SP.Controls.Add(this.SerialName);
            this.SP.Controls.Add(this.label7);
            this.SP.Location = new System.Drawing.Point(4, 21);
            this.SP.Name = "SP";
            this.SP.Padding = new System.Windows.Forms.Padding(3);
            this.SP.Size = new System.Drawing.Size(803, 36);
            this.SP.TabIndex = 2;
            this.SP.Text = "串口";
            this.SP.UseVisualStyleBackColor = true;
            // 
            // tcpIP
            // 
            this.tcpIP.Location = new System.Drawing.Point(81, 9);
            this.tcpIP.Name = "tcpIP";
            this.tcpIP.Size = new System.Drawing.Size(158, 21);
            this.tcpIP.TabIndex = 0;
            this.tcpIP.Text = "127.0.0.1";
            // 
            // tcpPort
            // 
            this.tcpPort.Location = new System.Drawing.Point(315, 9);
            this.tcpPort.Name = "tcpPort";
            this.tcpPort.Size = new System.Drawing.Size(97, 21);
            this.tcpPort.TabIndex = 1;
            this.tcpPort.Text = "8000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "服务器地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "服务器端口：";
            // 
            // udpPort
            // 
            this.udpPort.Location = new System.Drawing.Point(315, 9);
            this.udpPort.Name = "udpPort";
            this.udpPort.Size = new System.Drawing.Size(97, 21);
            this.udpPort.TabIndex = 5;
            this.udpPort.Text = "8000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "服务器端口：";
            // 
            // udpIp
            // 
            this.udpIp.Location = new System.Drawing.Point(81, 9);
            this.udpIp.Name = "udpIp";
            this.udpIp.Size = new System.Drawing.Size(158, 21);
            this.udpIp.TabIndex = 4;
            this.udpIp.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "服务器地址：";
            // 
            // udpLocalPort
            // 
            this.udpLocalPort.Location = new System.Drawing.Point(484, 9);
            this.udpLocalPort.Name = "udpLocalPort";
            this.udpLocalPort.Size = new System.Drawing.Size(97, 21);
            this.udpLocalPort.TabIndex = 8;
            this.udpLocalPort.Text = "4000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "本地端口：";
            // 
            // SerialBaudRate
            // 
            this.SerialBaudRate.FormattingEnabled = true;
            this.SerialBaudRate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "38400",
            "56000",
            "19200",
            "57600",
            "115200",
            "128000",
            "230400",
            "256000",
            "460800"});
            this.SerialBaudRate.Location = new System.Drawing.Point(223, 10);
            this.SerialBaudRate.Name = "SerialBaudRate";
            this.SerialBaudRate.Size = new System.Drawing.Size(88, 20);
            this.SerialBaudRate.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 38;
            this.label6.Text = "波特率：";
            // 
            // SerialName
            // 
            this.SerialName.FormattingEnabled = true;
            this.SerialName.Location = new System.Drawing.Point(69, 10);
            this.SerialName.Name = "SerialName";
            this.SerialName.Size = new System.Drawing.Size(87, 20);
            this.SerialName.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 37;
            this.label7.Text = "串口号：";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Location = new System.Drawing.Point(660, 9);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(66, 20);
            this.comboBoxParity.TabIndex = 45;
            // 
            // DataBits
            // 
            this.DataBits.FormattingEnabled = true;
            this.DataBits.Items.AddRange(new object[] {
            "8"});
            this.DataBits.Location = new System.Drawing.Point(520, 9);
            this.DataBits.Name = "DataBits";
            this.DataBits.Size = new System.Drawing.Size(66, 20);
            this.DataBits.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(604, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 43;
            this.label8.Text = "校验位：";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Location = new System.Drawing.Point(374, 10);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(66, 20);
            this.comboBoxStopBits.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(463, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 41;
            this.label9.Text = "数据位：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(317, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 40;
            this.label10.Text = "停止位：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 326);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "测试窗口";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.TCP.ResumeLayout(false);
            this.TCP.PerformLayout();
            this.UDP.ResumeLayout(false);
            this.UDP.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SP.ResumeLayout(false);
            this.SP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage TCP;
        private System.Windows.Forms.TabPage UDP;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textRead;
        private System.Windows.Forms.TextBox textSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TabPage SP;
        private System.Windows.Forms.TextBox tcpPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tcpIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox udpPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox udpIp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox udpLocalPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SerialBaudRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SerialName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.ComboBox DataBits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}