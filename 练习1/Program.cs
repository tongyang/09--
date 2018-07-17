using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Practice1();
            //Practice2();
            Practice3();
        }

        public static void Practice1()
        {
            Console.WriteLine("请随机输入一个名字");
            string name = Console.ReadLine();
            Console.WriteLine("您输入的名字长度为：{0}", name.Length);
            Console.ReadKey();
            
        }
        public static void Practice2()
        {
            Console.WriteLine("请输入您喜欢的课程名称：");
            string leson1 = Console.ReadLine();
            Console.WriteLine("请输入您喜欢的课程名称：");
            string leson2 = Console.ReadLine();

            //leson1 = leson1.ToUpper();
            //leson2 = leson2.ToUpper();

            if (leson1.Equals(leson2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("你们喜欢的课程相同");
            }
            else
            {
                Console.WriteLine("你们喜欢的课程不同");
            }
            Console.ReadKey();
        }

        public static void Practice3()
        {
            Console.WriteLine("请输入当前日期（格式为：2008-01-02）：");
            string str = Console.ReadLine();
            char[] chs = {'-'};
            string[] strs = str.Split(chs, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("您输入的时间为：{0}年{1}月{2}日", strs[0], strs[1], strs[2]);
            Console.ReadKey();
        }
    }
}
