namespace Server
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBeginListen = new System.Windows.Forms.Button();
            this.txtServerState = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstClient = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSendAll = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkAlConnect = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSaveLog = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtSerFilePort = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboMaxCount = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNowCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSerProtocol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSerPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSerIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancelJY = new System.Windows.Forms.Button();
            this.btnJY = new System.Windows.Forms.Button();
            this.btnTR = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBeginListen
            // 
            this.btnBeginListen.Location = new System.Drawing.Point(71, 386);
            this.btnBeginListen.Name = "btnBeginListen";
            this.btnBeginListen.Size = new System.Drawing.Size(38, 23);
            this.btnBeginListen.TabIndex = 0;
            this.btnBeginListen.Text = "开始";
            this.btnBeginListen.UseVisualStyleBackColor = true;
            this.btnBeginListen.Click += new System.EventHandler(this.btnBeginListen_Click);
            // 
            // txtServerState
            // 
            this.txtServerState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServerState.Location = new System.Drawing.Point(3, 17);
            this.txtServerState.Multiline = true;
            this.txtServerState.Name = "txtServerState";
            this.txtServerState.Size = new System.Drawing.Size(531, 278);
            this.txtServerState.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtServerState);
            this.groupBox2.Location = new System.Drawing.Point(227, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 298);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户聊天信息";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstClient);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 371);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "客户端列表";
            // 
            // lstClient
            // 
            this.lstClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstClient.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstClient.FormattingEnabled = true;
            this.lstClient.ItemHeight = 21;
            this.lstClient.Location = new System.Drawing.Point(3, 17);
            this.lstClient.Name = "lstClient";
            this.lstClient.Size = new System.Drawing.Size(209, 351);
            this.lstClient.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSendAll);
            this.groupBox4.Controls.Add(this.btnSend);
            this.groupBox4.Controls.Add(this.txtSend);
            this.groupBox4.Location = new System.Drawing.Point(227, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(537, 129);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "发送给客户端的消息";
            // 
            // btnSendAll
            // 
            this.btnSendAll.Location = new System.Drawing.Point(469, 91);
            this.btnSendAll.Name = "btnSendAll";
            this.btnSendAll.Size = new System.Drawing.Size(61, 32);
            this.btnSendAll.TabIndex = 8;
            this.btnSendAll.Text = "群发信息";
            this.btnSendAll.UseVisualStyleBackColor = true;
            this.btnSendAll.Click += new System.EventHandler(this.btnSendAll_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(402, 92);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(61, 32);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(3, 19);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(528, 67);
            this.txtSend.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 473);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkAlConnect);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnSaveLog);
            this.tabPage1.Controls.Add(this.btnClearLog);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.btnPause);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.btnBeginListen);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "服务器管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkAlConnect
            // 
            this.chkAlConnect.AutoSize = true;
            this.chkAlConnect.Checked = true;
            this.chkAlConnect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlConnect.Location = new System.Drawing.Point(248, 388);
            this.chkAlConnect.Name = "chkAlConnect";
            this.chkAlConnect.Size = new System.Drawing.Size(48, 16);
            this.chkAlConnect.TabIndex = 18;
            this.chkAlConnect.Text = "连接";
            this.chkAlConnect.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "允许用户：";
            // 
            // btnSaveLog
            // 
            this.btnSaveLog.Location = new System.Drawing.Point(257, 353);
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(75, 23);
            this.btnSaveLog.TabIndex = 16;
            this.btnSaveLog.Text = "保存日志";
            this.btnSaveLog.UseVisualStyleBackColor = true;
            this.btnSaveLog.Click += new System.EventHandler(this.btnSaveLog_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(172, 353);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearLog.TabIndex = 15;
            this.btnClearLog.Text = "清 屏";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtLog);
            this.groupBox5.Location = new System.Drawing.Point(169, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(600, 342);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "服务器日志：";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.Location = new System.Drawing.Point(6, 15);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(554, 318);
            this.txtLog.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(113, 386);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(17, 386);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(48, 23);
            this.btnPause.TabIndex = 12;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtSerFilePort);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.cboMaxCount);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.txtNowCount);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.txtSerProtocol);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.txtSerPort);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.txtSerIP);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.txtSerName);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.txtStatu);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(8, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(155, 372);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "服务器信息";
            // 
            // txtSerFilePort
            // 
            this.txtSerFilePort.Location = new System.Drawing.Point(78, 188);
            this.txtSerFilePort.Name = "txtSerFilePort";
            this.txtSerFilePort.Size = new System.Drawing.Size(71, 21);
            this.txtSerFilePort.TabIndex = 16;
            this.txtSerFilePort.Text = "5555";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "文件端口：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(123, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "人";
            // 
            // cboMaxCount
            // 
            this.cboMaxCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaxCount.FormattingEnabled = true;
            this.cboMaxCount.Items.AddRange(new object[] {
            "50",
            "40",
            "30",
            "20",
            "10",
            "5",
            "1"});
            this.cboMaxCount.Location = new System.Drawing.Point(9, 340);
            this.cboMaxCount.Name = "cboMaxCount";
            this.cboMaxCount.Size = new System.Drawing.Size(109, 20);
            this.cboMaxCount.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "最大负荷(限制)：";
            // 
            // txtNowCount
            // 
            this.txtNowCount.Location = new System.Drawing.Point(9, 290);
            this.txtNowCount.Name = "txtNowCount";
            this.txtNowCount.Size = new System.Drawing.Size(140, 21);
            this.txtNowCount.TabIndex = 11;
            this.txtNowCount.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "当前连接负荷：";
            // 
            // txtSerProtocol
            // 
            this.txtSerProtocol.Location = new System.Drawing.Point(9, 239);
            this.txtSerProtocol.Name = "txtSerProtocol";
            this.txtSerProtocol.Size = new System.Drawing.Size(140, 21);
            this.txtSerProtocol.TabIndex = 9;
            this.txtSerProtocol.Text = "Tcp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "访问协议：";
            // 
            // txtSerPort
            // 
            this.txtSerPort.Location = new System.Drawing.Point(9, 188);
            this.txtSerPort.Name = "txtSerPort";
            this.txtSerPort.Size = new System.Drawing.Size(63, 21);
            this.txtSerPort.TabIndex = 7;
            this.txtSerPort.Text = "5555";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "消息端口：";
            // 
            // txtSerIP
            // 
            this.txtSerIP.Location = new System.Drawing.Point(9, 139);
            this.txtSerIP.Name = "txtSerIP";
            this.txtSerIP.Size = new System.Drawing.Size(140, 21);
            this.txtSerIP.TabIndex = 5;
            this.txtSerIP.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "服务器IP：";
            // 
            // txtSerName
            // 
            this.txtSerName.Location = new System.Drawing.Point(9, 88);
            this.txtSerName.Name = "txtSerName";
            this.txtSerName.Size = new System.Drawing.Size(140, 21);
            this.txtSerName.TabIndex = 3;
            this.txtSerName.Text = "ServerPC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "服务器名称：";
            // 
            // txtStatu
            // 
            this.txtStatu.Location = new System.Drawing.Point(9, 37);
            this.txtStatu.Name = "txtStatu";
            this.txtStatu.Size = new System.Drawing.Size(140, 21);
            this.txtStatu.TabIndex = 1;
            this.txtStatu.Text = "停止";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "状态：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCancelJY);
            this.tabPage2.Controls.Add(this.btnJY);
            this.tabPage2.Controls.Add(this.btnTR);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "用户管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCancelJY
            // 
            this.btnCancelJY.Location = new System.Drawing.Point(81, 412);
            this.btnCancelJY.Name = "btnCancelJY";
            this.btnCancelJY.Size = new System.Drawing.Size(61, 23);
            this.btnCancelJY.TabIndex = 11;
            this.btnCancelJY.Text = "解禁";
            this.btnCancelJY.UseVisualStyleBackColor = true;
            this.btnCancelJY.Click += new System.EventHandler(this.btnCancelJY_Click);
            // 
            // btnJY
            // 
            this.btnJY.Location = new System.Drawing.Point(9, 412);
            this.btnJY.Name = "btnJY";
            this.btnJY.Size = new System.Drawing.Size(61, 23);
            this.btnJY.TabIndex = 10;
            this.btnJY.Text = "禁言";
            this.btnJY.UseVisualStyleBackColor = true;
            this.btnJY.Click += new System.EventHandler(this.btnJY_Click);
            // 
            // btnTR
            // 
            this.btnTR.Location = new System.Drawing.Point(8, 383);
            this.btnTR.Name = "btnTR";
            this.btnTR.Size = new System.Drawing.Size(61, 23);
            this.btnTR.TabIndex = 9;
            this.btnTR.Text = "踢人";
            this.btnTR.UseVisualStyleBackColor = true;
            this.btnTR.Click += new System.EventHandler(this.btnTR_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(777, 447);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "log.txt";
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 473);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBeginListen;
        private System.Windows.Forms.TextBox txtServerState;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSendAll;
        private System.Windows.Forms.ListBox lstClient;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnJY;
        private System.Windows.Forms.Button btnTR;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox chkAlConnect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSaveLog;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboMaxCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNowCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSerProtocol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSerPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSerIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelJY;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.TextBox txtSerFilePort;
        private System.Windows.Forms.Label label9;
    }
}

