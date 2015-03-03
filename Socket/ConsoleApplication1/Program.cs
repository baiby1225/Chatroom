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

            string xx = Encoding.UTF8.GetString(bytClient);
            byte[] byts = Encoding.UTF8.GetBytes(xx);

            string xxx = string.Format("{0}|{1}|{2}|{3}|{4}", "a", "b", "c", "d", Encoding.UTF8.GetString(byts));

            Console.ReadKey();
        }
    }
}
