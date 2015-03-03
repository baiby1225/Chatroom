namespace Client
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
            this.btnConnection = new System.Windows.Forms.Button();
            this.lblUid = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstFriends = new System.Windows.Forms.ListBox();
            this.sfgDialog = new System.Windows.Forms.SaveFileDialog();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShake = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(865, 19);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(90, 23);
            this.btnConnection.TabIndex = 0;
            this.btnConnection.Text = "连接";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // lblUid
            // 
            this.lblUid.AutoSize = true;
            this.lblUid.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUid.Location = new System.Drawing.Point(102, 9);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(63, 22);
            this.lblUid.TabIndex = 2;
            this.lblUid.Text = "未连接.";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(18, 14);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(65, 12);
            this.lable.TabIndex = 5;
            this.lable.Text = "本机地址：";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(13, 270);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(732, 85);
            this.txtMessage.TabIndex = 7;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(682, 375);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(63, 22);
            this.btnSendMsg.TabIndex = 5;
            this.btnSendMsg.Text = "发送消息";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(13, 17);
            this.txtReceived.Multiline = true;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(732, 241);
            this.txtReceived.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnShake);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtReceived);
            this.groupBox3.Controls.Add(this.btnSendFile);
            this.groupBox3.Controls.Add(this.btnSendMsg);
            this.groupBox3.Controls.Add(this.btnChooseFile);
            this.groupBox3.Controls.Add(this.txtMessage);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtFilePath);
            this.groupBox3.Location = new System.Drawing.Point(210, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(761, 489);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "消息";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstFriends);
            this.groupBox4.Location = new System.Drawing.Point(11, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(193, 489);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "客户端列表";
            // 
            // lstFriends
            // 
            this.lstFriends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFriends.FormattingEnabled = true;
            this.lstFriends.ItemHeight = 12;
            this.lstFriends.Location = new System.Drawing.Point(3, 17);
            this.lstFriends.MultiColumn = true;
            this.lstFriends.Name = "lstFriends";
            this.lstFriends.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstFriends.Size = new System.Drawing.Size(187, 469);
            this.lstFriends.TabIndex = 0;
            // 
            // sfgDialog
            // 
            this.sfgDialog.Filter = "所有文件|*.*";
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "所有文件|*.*";
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(612, 375);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(64, 23);
            this.btnSendFile.TabIndex = 36;
            this.btnSendFile.Text = "发送文件";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(545, 375);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(61, 23);
            this.btnChooseFile.TabIndex = 34;
            this.btnChooseFile.Text = "选择文件";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 37;
            this.label5.Text = "文件路径：";
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtFilePath.Location = new System.Drawing.Point(83, 376);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(427, 21);
            this.txtFilePath.TabIndex = 35;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(664, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 23);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "退 出";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnShake
            // 
            this.btnShake.Location = new System.Drawing.Point(83, 415);
            this.btnShake.Name = "btnShake";
            this.btnShake.Size = new System.Drawing.Size(88, 23);
            this.btnShake.TabIndex = 40;
            this.btnShake.Text = "发送窗口抖动";
            this.btnShake.UseVisualStyleBackColor = true;
            this.btnShake.Click += new System.EventHandler(this.btnShake_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 39;
            this.label4.Text = "其他功能：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 558);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblUid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Client";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Label lblUid;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstFriends;
        private System.Windows.Forms.SaveFileDialog sfgDialog;
        private System.Windows.Forms.Label lable;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShake;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

