using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Collections;
using System.IO;
using Common;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;
            skinEngine1.SkinFile = "MidsummerColor1.ssk";
        }

        Socket socketClient = null;
        string localName;

        private void btnConnection_Click(object sender, EventArgs e)
        {
            ConnectionServer connectionserver = new ConnectionServer("127.0.0.1", "5555");
            socketClient = connectionserver.Connection2Server();
            this.lblUid.Text = localName = socketClient.LocalEndPoint.ToString();
            this.btnConnection.Enabled = false;
            Thread thrReceived = new Thread(ReceiveMsg);
            thrReceived.IsBackground = true;
            thrReceived.SetApartmentState(ApartmentState.STA);
            thrReceived.Start();
        }
        bool receiveFlag = true;
        private void ReceiveMsg()
        {
            try
            {
                while (receiveFlag)
                {
                    byte[] bytes = new byte[1024 * 1024 * 2];
                    socketClient.Receive(bytes);
                    string receiveMsg = Encoding.UTF8.GetString(bytes);
                    MessageMod mod = new MessageMod(receiveMsg);
                    switch (mod.MsgType)
                    {
                        case (int)Common.PubClass.MsgType.Client2Client:
                            this.txtReceived.AppendTxt(string.Format("【{0}】发来:{1}", mod.FromUser, mod.Content));
                            break;
                        case (int)Common.PubClass.MsgType.RadioClients:
                            lstFriends.Items.Clear();
                            string[] strs = mod.Content.Split('^');
                            foreach (var item in strs)
                            {
                                if (!this.lstFriends.Items.Contains(item) && item != socketClient.LocalEndPoint.ToString())
                                {
                                    this.lstFriends.Items.Add(item);
                                }
                            }
                            break;
                        case (int)Common.PubClass.MsgType.TR:
                            this.txtReceived.AppendTxt(mod.Content);
                            socketClient.Close();
                            receiveFlag = false;
                            System.Timers.Timer tim = new System.Timers.Timer(3000);
                            tim.Enabled = true;
                            tim.Elapsed += (object sender, System.Timers.ElapsedEventArgs e) => { this.Close(); };
                            break;
                        case (int)Common.PubClass.MsgType.ServerClosed:
                            socketClient.Close();
                            this.txtReceived.AppendTxt("服务器连接失败,3秒后关闭客户端...");
                            System.Timers.Timer timer = new System.Timers.Timer(3000);
                            timer.Enabled = true;
                            timer.Elapsed += (object sender, System.Timers.ElapsedEventArgs e) => { this.Close(); };

                            break;
                        case (int)Common.PubClass.MsgType.JY:
                            this.txtReceived.AppendTxt(mod.Content);
                            this.btnSendMsg.Enabled = false;
                            this.txtMessage.BackColor = Color.Red;
                            break;
                        case (int)Common.PubClass.MsgType.CancelJY:
                            this.txtReceived.AppendTxt(mod.Content);
                            this.btnSendMsg.Enabled = true;
                            this.txtMessage.BackColor = Color.White;
                            break;
                        case (int)Common.PubClass.MsgType.Client2ClientFile:
                            if (MessageBox.Show("是否接收？", mod.FromUser + "发来文件", MessageBoxButtons.YesNoCancel)
            == System.Windows.Forms.DialogResult.Yes)
                            {
                                if (sfgDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                {
                                    using (FileStream fs = new FileStream(sfgDialog.FileName, FileMode.Create))
                                    {
                                        fs.Write(mod.ContentBytes, 0, mod.ContentBytes.Length);
                                        txtReceived.AppendTxt("收到一个文件" + sfgDialog.FileName);
                                    }
                                }
                                else
                                {
                                    txtReceived.AppendTxt("取消接受文件" + sfgDialog.FileName);
                                }
                            }
                            break;
                        case (int)Common.PubClass.MsgType.ShineScreen:


                            ShakeWindow();



                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("服务器连接失败,3秒后关闭客户端...");
                System.Timers.Timer timer = new System.Timers.Timer(3000);
                timer.Enabled = true;
                timer.Elapsed += (object sender, System.Timers.ElapsedEventArgs e) => { this.Close(); };

            }
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            string SelectFriend = GetSelectClient();
            if (SelectFriend.Length == 0) return;
            if (txtMessage.Text.Length == 0) { MessageBox.Show("聊天信息为空"); return; }
            if (receiveFlag)
            {
                MessageMod mod = new MessageMod();
                mod.MsgType = (int)Common.PubClass.MsgType.Client2Client;
                mod.FromUser = localName;
                mod.ToUser = SelectFriend;
                mod.Content = this.txtMessage.Text;
                socketClient.Send(mod.ToBytes());
                this.txtMessage.Text = "";
            }
            else
            {
                MessageBox.Show("服务器已停止响应！");
            }
        }

        private string GetSelectClient()
        {
            if (lstFriends.SelectedItem != null)
            {
                return lstFriends.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("请选择一个好友"); return "";
            }
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            string SelectFriend = GetSelectClient();
            if (SelectFriend.Length == 0) return;
            string fileName = txtFilePath.Text;
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("请选择文件"); return;
            }
            MessageMod mod = new MessageMod();
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                byte[] byts = new byte[1024 * 1024 * 2];
                fs.Read(byts, 0, (int)fs.Length);
                mod.ContentBytes = byts;
            }
            mod.MsgType = (int)Common.PubClass.MsgType.Client2ClientFile;
            mod.FromUser = localName;
            mod.ToUser = SelectFriend;
            mod.Content = fileName;
            socketClient.Send(mod.ToBytes());

        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtFilePath.Text = openFileDialog.FileName;
                this.txtFilePath.Enabled = false;
            }
        }

        private void btnShake_Click(object sender, EventArgs e)
        {
            string SelectFriend = GetSelectClient();
            if (SelectFriend.Length == 0) return;
            MessageMod mod = new MessageMod();
            mod.MsgType = (int)Common.PubClass.MsgType.ShineScreen;
            mod.FromUser = localName;
            mod.ToUser = SelectFriend;
            mod.Content = "Shake";
            socketClient.Send(mod.ToBytes());
        }
        public void ShakeWindow()
        {
            Random ran = new Random();
            System.Drawing.Point point = this.Location;
            for (int i = 0; i < 30; i++)
            {
                this.Location = new System.Drawing.Point(point.X + ran.Next(5), point.Y + ran.Next(5));
                System.Threading.Thread.Sleep(15);
                this.Location = point;
                System.Threading.Thread.Sleep(15);
            }
        }
    }
}
