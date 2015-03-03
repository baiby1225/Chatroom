using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ninject;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            StandardKernel standard = new StandardKernel();
            standard.Bind<IBLL>().To<Log2TxtBll>();

            ILog bll = standard.Get<Log2Txt>();
            bll.WriteLog("logtype", "ss");

            byte[] bytClient = new byte[2];
            bytClient[0] = byte.Parse("53");

            var  xx = Encoding.UTF8.GetString(bytClient);

            Console.ReadKey();
        }
    }
}
