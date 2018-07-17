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
            //Practice3();
            //Test();
            //Practice4();
            //Practice5();
            //Practice6();
            Practice7();
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

        public static void Test()
        {
            string str = "今天天气好晴朗，天天处处好风光。";
            int[] indexs = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                int index = str.IndexOf('天', i);
                indexs[i] = index;
            }
            // 去重
            indexs = indexs.Distinct().ToArray();
            // 去掉负值
            
            foreach (int temp in indexs)
            {
                Console.WriteLine(temp);
            }
            Console.ReadKey();
        }

        public static void Practice4()
        {
            Console.WriteLine("请输入一串字符：");
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder(str.Length);
            for (int i = str.Length - 1; i >= 0 ; i--)
            {
                sb.Append(str[i]);
            }
            str = sb.ToString();
            Console.WriteLine(str);
            Console.ReadKey();
        }

        public static void Practice5()
        {
            Console.WriteLine("请输出一句标准英文：");
            string str = Console.ReadLine();
            char[] chs = { ' '};
            string[] strs = str.Split(chs);
            Array.Reverse(strs);
            for (int i = 0; i < strs.Length - 1; i++)
            {
                Console.Write(strs[i] + " ");
                
            }
            Console.Write(strs[strs.Length - 1]);
            Console.ReadKey();
        }

        public static void Practice6()
        {
            Console.WriteLine("请输入您的邮箱地址：");
            string email = Console.ReadLine();
            char[] chs = { '@' };
            string[] strs = email.Split(chs);
            Console.WriteLine("您的账号名为：{0}，域名为：{1}", strs[0], strs[1]);
            Console.ReadKey();
        }

        public static void Practice7()
        {
            string str = "《皮皮鲁与鲁西西的奇幻历险记》    郑渊洁";
            char[] chs = { ' '};
            string[] strs = str.Split(chs);
            str =  string.Join("|", strs);
            for (int i = 0; i < strs.Length; i++)
            {
                if (string.IsNullOrEmpty(strs[i]) == false)
                {
                    if (strs[i].Length > 10)
                    {
                        string temp = strs[i].Substring(0, 8);
                        temp += "...";
                        Console.Write(temp);
                    }
                    else
                    {
                        Console.Write(strs[i]);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
