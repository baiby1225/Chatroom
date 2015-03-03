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
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(373, 15);
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
            this.lblUid.Location = new System.Drawing.Point(113, 15);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(63, 22);
            this.lblUid.TabIndex = 2;
            this.lblUid.Text = "未连接.";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(29, 20);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(65, 12);
            this.lable.TabIndex = 5;
            this.lable.Text = "本机地址：";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(21, 270);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(237, 85);
            this.txtMessage.TabIndex = 7;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(168, 358);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(90, 31);
            this.btnSendMsg.TabIndex = 5;
            this.btnSendMsg.Text = "发送消息";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(19, 17);
            this.txtReceived.Multiline = true;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(237, 241);
            this.txtReceived.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtReceived);
            this.groupBox3.Controls.Add(this.btnSendMsg);
            this.groupBox3.Controls.Add(this.txtMessage);
            this.groupBox3.Location = new System.Drawing.Point(210, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 392);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "消息";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstFriends);
            this.groupBox4.Location = new System.Drawing.Point(11, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(193, 392);
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
            this.lstFriends.Size = new System.Drawing.Size(187, 372);
            this.lstFriends.TabIndex = 0;
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
            this.ClientSize = new System.Drawing.Size(504, 474);
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
    }
}

