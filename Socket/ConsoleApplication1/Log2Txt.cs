﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
  public  class Log2Txt:ILog
    {
        public void WriteLog(string logType, string Content)
        {
            Console.WriteLine("log to txt" + logType + ":" + Content);
        }
    }
}
