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
            Console.ReadKey();
        }
    }
}
