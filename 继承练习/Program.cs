using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Reporter rep = new Reporter(30, "童扬", "打篮球");
            rep.SayHello(rep.Name, rep.Habbit);

            Person p = new Driver("to", 12);
            

            // is与as的用法
            if (p is Reporter)
            {
                Reporter r = (Reporter)p;
            }
            else
            {
                Console.WriteLine("转换失败");
            }

            Driver d = p as Driver;

            Console.ReadKey();
        }
    }
}
