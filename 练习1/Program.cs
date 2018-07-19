using System;
using System.Collections.Generic;
using System.IO;
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
            //Practice7();
            //Practice8();
            //Practice9();
            Practice10();
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
            string filePath = @"D:\WorkSpace\09-面向对象继承\1.txt";
            string[] contents = File.ReadAllLines(filePath, System.Text.Encoding.Default);
            char[] chs = { ' '};
            string[] content = new string[2];
            for (int i = 0; i < contents.Length; i++)
            {
                content = contents[i].Split(chs, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < content.Length; j++)
                {
                    if (content[j].Length > 10)
                    {
                        content[j] = content[j].Substring(0, 8) + "......";
                    }
                }
                contents[i] = string.Join("|", content);
                Console.WriteLine(contents[i]);
            }
            Console.ReadKey();
        }

        public static void Practice8()
        {
            Console.WriteLine("请输入随意一行语句，最好包含多个字母e：");
            string str = Console.ReadLine();
            int[] indexs = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                int index = str.IndexOf('e', i);
                indexs[i] = index;
            }
            indexs = indexs.Distinct().ToArray();
            for (int i = 0; i < indexs.Length; i++)
            {
                if (indexs[i] >= 0)
                {
                    Console.WriteLine("第{0}次出现在{1}位", i + 1, indexs[i] + 1);
                }
            }
            Console.ReadKey();
        }

        public static void Practice9()
        {
            Console.WriteLine("请您随意输入一段话：");
            string str = Console.ReadLine();
            if (str.Contains("邪恶"))
            {
                str = str.Replace("邪恶", "**");
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }

        public static void Practice10()
        {
            string[] names = { "诸葛亮", "鸟叔", "卡卡西", "卡哇伊" };
            StringBuilder sb = new StringBuilder(names.Length);

            string str = string.Join("|", names);
            Console.WriteLine(str);
            Console.ReadKey();
            str = str.Replace("|", "");
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
