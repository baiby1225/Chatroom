﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public interface ILog
    {
        void WriteLog(string logType, string content);
    }
}
