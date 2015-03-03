using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
  public  class Log2TxtBll:IBLL
    {
         private ILog _log;
         public Log2TxtBll(ILog log)
        {
            _log = log;
        }
        public void WriteLog(string logType, string content)
        {
            _log.WriteLog(logType, content);
        }
    }
}
