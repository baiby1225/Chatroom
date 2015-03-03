using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common {
    public class MessageMod {
        public MessageMod () {

        }
        public MessageMod ( string str ) {
            try {
                string [] strs = str.Split('|');
                if (strs.Length < 5) {
                    this.MsgType = Convert.ToInt32(str [0].ToString());
                    this.FromUser = Convert.ToString(strs [1]);
                    this.ToUser = Convert.ToString(strs [2]);
                    this.Content = Convert.ToString(strs [3].Trim("\0".ToCharArray()));
                } else {
                    this.MsgType = 0;
                    this.FromUser = "";
                    this.ToUser = "";
                    this.Content = "";
                }

            } catch {
                this.MsgType = 0;
                this.FromUser = "";
                this.ToUser = "";
                this.Content = "";
            }
        }
        /// <summary>
        /// 消息类型
        /// </summary>
        private int _msgType;

        public int MsgType {
            get {

                return _msgType;

            }
            set { _msgType = value; }
        }

        /// <summary>
        /// 发送者
        /// </summary>
        public string FromUser { get; set; }
        /// <summary>
        /// 接收者
        /// </summary>
        public string ToUser { get; set; }
        /// <summary>
        /// 消息内容
        /// </summary>
        public string Content { get; set; }

        public override string ToString () {
            return string.Format("{0}|{1}|{2}|{3}", MsgType, FromUser, ToUser, Content);
        }

        public byte [] ToBytes () {
            byte [] byts = Encoding.UTF8.GetBytes(this.ToString());
            return byts;
        }


    }
}
