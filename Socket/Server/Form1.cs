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
using System.IO;
using Common;

namespace Server
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;

            ComboBox.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            skinEngine1.SkinFile = "MidsummerColor1.ssk";
        }


        //监听socket
        Socket socketServer = null;

        //客户端列表
        Dictionary<string, Socket> dictClients = new Dictionary<string, Socket>();

        Thread thrReadRec = null;
        int maxCount = 0;
        private void btnBeginListen_Click(object sender, EventArgs e)
        {
            this.txtStatu.Text = "正在运行..";
            maxCount = int.Parse(cboMaxCount.SelectedItem.ToString());
            socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipaddress = IPAddress.Parse(txtSerIP.Text.ToString());
            IPEndPoint ipendpoint = new IPEndPoint(ipaddress, int.Parse(txtSerPort.Text.ToString()));
            socketServer.Bind(ipendpoint);
            socketServer.Listen(maxCount);
            //创建线程 负责监听
            Thread threadWatch = new Thread(WatchConnection);
            //设置为后台线程
            threadWatch.IsBackground = true;
            //开启线程
            threadWatch.Start();
            this.txtLog.AppendTxt("Server is Listening....");
            this.btnBeginListen.Enabled = false;



        }

        bool watchFlag = true;
        private void WatchConnection()
        {

            try
            {
                while (watchFlag)
                {
                    Socket socketConn = socketServer.Accept();
                    string clientName = socketConn.RemoteEndPoint.ToString();
                    this.lstClient.Items.Add(clientName);
                    dictClients.Add(clientName, socketConn);
                    if (dictClients.Count > maxCount)
                    {
                        txtLog.AppendTxt(clientName + "未连接成功,原因:【当前连接数已经超过最大限制】");
                        Server2ClientMsg(clientName, "当前连接数已经超过最大限制，请稍后重试", false);
                        socketConn.Close();
                    }
                    SendFrientToAll();
                    this.txtLog.AppendTxt("客户端连接成功：" + clientName);
                    this.txtNowCount.Text = (int.Parse(txtNowCount.Text.ToString()) + 1).ToString();
                    thrReadRec = new Thread(() => { ReceiveMsg(socketConn); });
                    thrReadRec.IsBackground = true;
                    thrReadRec.Start();

                }
            }
            catch (Exception)
            {

            }

        }

        private void SendFrientToAll()
        {
            if (dictClients.Count < 1)
            {
                return;
            }
            string clients = "";
            foreach (KeyValuePair<string, Socket> item in dictClients)
            {
                clients += "^" + item.Key;
            }
            clients = clients.Substring(1);
            MessageMod mod = new MessageMod();
            mod.MsgType = (int)Common.PubClass.MsgType.RadioClients;
            mod.FromUser = socketServer.LocalEndPoint.ToString();
            mod.ToUser = "all";
            mod.Content = clients;

            foreach (var item in dictClients)
            {
                item.Value.Send(mod.ToBytes());
            }

        }

        private void ReceiveMsg(Socket socketConn)
        {

            try
            {
                while (true)
                {
                    byte[] bytes = new byte[1024 * 1024 * 2];
                    socketConn.Receive(bytes);
                    string receiveMsg = Encoding.UTF8.GetString(bytes);
                    MessageMod mod = new MessageMod(receiveMsg);
                    switch (mod.MsgType)
                    {
                        case (int)Common.PubClass.MsgType.Client2Client:
                            this.txtServerState.AppendTxt(string.Format("【{0}】对【{1}】说{2}", mod.FromUser, mod.ToUser, mod.Content));
                            foreach (var item in dictClients)
                            {
                                if (item.Key == mod.ToUser)
                                {
                                    item.Value.Send(bytes);
                                }
                            }
                            break;
                        case (int)Common.PubClass.MsgType.Client2Server:
                            string clientName = socketConn.RemoteEndPoint.ToString();
                            this.txtServerState.AppendTxt(clientName + "对你说" + receiveMsg + "\r\n");
                            break;
                    }

                }
            }
            catch
            {
                string connName = socketConn.RemoteEndPoint.ToString();
                this.txtLog.AppendTxt(connName + "下线啦~");
                txtNowCount.Text = (int.Parse(txtNowCount.Text) - 1).ToString();
                dictClients.Remove(connName);
                this.lstClient.Items.Remove(connName);
            }
        }

        #region 发送消息
        private void btnSend_Click(object sender, EventArgs e)
        {
            string currentClient = GetSelectClient();
            if (currentClient.Length == 0) return;
            Server2ClientMsg(currentClient, this.txtSend.Text, false);

        }

        private string GetSelectClient()
        {
            if (lstClient.SelectedItem != null)
            {
                return lstClient.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("请选择一个客户端"); return "";
            }
        }

        private void btnSendAll_Click(object sender, EventArgs e)
        {
            string msg = this.txtSend.Text;
            Server2ClientMsg("all", msg, true);
        }

        private void Server2AllClientMsg(string msg, Common.PubClass.MsgType type)
        {
            Server2ClientMsg("all", msg, true, type);
        }

        private void Server2ClientMsg(string toUser, string msg, bool isAll, Common.PubClass.MsgType type = Common.PubClass.MsgType.Server2ClientMsg)
        {

            MessageMod mod = new MessageMod();
            mod.MsgType = (int)type;
            mod.FromUser = socketServer.LocalEndPoint.ToString();
            mod.ToUser = toUser;
            mod.Content = msg;
            byte[] bytes = mod.ToBytes();
            txtServerState.AppendTxt("【" + txtSerName.Text + "】" + "发给" + "【" + mod.ToUser + "】" + ":" + msg);
            foreach (KeyValuePair<string, Socket> item in dictClients)
            {
                if (isAll)
                {
                    item.Value.Send(bytes);

                }
                else
                {
                    if (item.Key == toUser)
                    {
                        item.Value.Send(bytes);
                    }
                }


            }
        }
        #endregion

        #region 发送文件

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            SendFile(false);
        }

        private void btnSendFileAll_Click(object sender, EventArgs e)
        {
            SendFile(true);
        }

        private void SendFile(bool isAll)
        {
            if (lstClient.SelectedItem == null && !isAll)
            {
                MessageBox.Show("请选择一个客户端");
            }
            else
            {
                if (txtFilePath.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("请选择文件"); return;
                }
                string path = txtFilePath.Text.Trim();
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    byte[] bytes = new byte[1024 * 1024 * 2];
                    fs.Read(bytes, 0, (int)fs.Length - 1);
                    byte[] bytefinal = new byte[bytes.Length + 1];
                    bytefinal[0] = (int)Common.PubClass.MsgType.Server2ClientFile;
                    Buffer.BlockCopy(bytes, 0, bytefinal, 1, bytefinal.Length - 1);


                    foreach (KeyValuePair<string, Socket> item in dictClients)
                    {
                        if (isAll)
                        {
                            item.Value.Send(bytefinal);
                        }
                        else
                        {
                            if (item.Key == lstClient.SelectedItem.ToString())
                            {
                                item.Value.Send(bytefinal);

                            }
                        }
                        this.txtFilePath.Enabled = true;
                    }

                }
            }
        }
        #endregion

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (opfileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtFilePath.Text = opfileDialog.FileName;
                this.txtFilePath.Enabled = false;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            socketServer.Blocking = true;
            this.txtStatu.Text = "已暂停..";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            Server2AllClientMsg("服务器已停止.", PubClass.MsgType.ServerClosed);
            socketServer.Close();
            socketServer.Dispose();
            thrReadRec.Abort();
            dictClients.Clear();
            this.txtStatu.Text = "已经停止..";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cboMaxCount.SelectedIndex = 0;
        }

        private void btnTR_Click(object sender, EventArgs e)
        {
            string currentClient = GetSelectClient();
            if (currentClient.Length == 0) return;
            Server2ClientMsg(currentClient, "您被管理员强制下线", false, PubClass.MsgType.TR);
            dictClients.Remove(currentClient);
            this.lstClient.Items.Remove(currentClient);
            txtLog.AppendTxt(currentClient + "被强制下线");
            SendFrientToAll();
            Server2AllClientMsg(currentClient + "被管理员强制下线", PubClass.MsgType.Server2ClientMsg);
        }

        private void btnJY_Click(object sender, EventArgs e)
        {
            string currentClient = GetSelectClient();
            if (currentClient.Length == 0) return;
            Server2ClientMsg(currentClient, "您被管理员禁言", false, PubClass.MsgType.JY);
        }

        private void btnCancelJY_Click(object sender, EventArgs e)
        {
            string currentClient = GetSelectClient();
            if (currentClient.Length == 0) return;
            Server2ClientMsg(currentClient, "您被管理员解除禁言", false, PubClass.MsgType.CancelJY);
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
        }

        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Append))
                {
                    byte[] byts = Encoding.UTF8.GetBytes(txtLog.Text);
                    fs.Write(byts, 0, byts.Length);
                    MessageBox.Show("日志保存成功" + saveFileDialog.FileName);
                }
            }

        }
    }
}
