using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common
{
    public class PubClass
    {
        public enum MsgType
        {
            Server2ClientMsg = 1,
            Server2ClientFile = 2,
            RadioClients = 3,
            Client2Server = 4,
            Client2Client = 5,
            ServerClosed = 6,
            TR = 7,
            JY = 8,
            CancelJY = 9,
            Client2ClientFile = 10,
            ShineScreen = 11,
            Other = 12
        }
    }

    public static class ExpentMethod
    {
        public static void AppendTxt(this TextBoxBase txtbox, string text)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
            txtbox.AppendText(text + "\r\n");
        }
    }
}
