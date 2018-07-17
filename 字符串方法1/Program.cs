using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串方法1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string str = null;

            // 创建一个计时器
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 100000; i++)
            {
                // str += i;
                sb.Append(i);
            }
            str = sb.ToString();
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();
        }
    }
}
