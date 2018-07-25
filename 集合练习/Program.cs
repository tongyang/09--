using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace 集合练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //Practise1();
            Practise2();
        }

        public static void Practise1()
        {
            ArrayList list = new ArrayList();
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                int rNum = r.Next(1, 100);
                list.Add(rNum);
            }

            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += (int)list[i];
            }

            int avg = sum / (list.Count);

            Console.WriteLine("总和为：{0}", sum);
            Console.WriteLine("平均数为：{0}", avg);

            Console.ReadKey();
        }

        public static void Practise2()
        {
            ArrayList list = new ArrayList();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {

                int rNum = r.Next(0, 10);
                if (!list.Contains(rNum))
                {
                    list.Add(rNum);
                }
                else
                {
                    i -= 1;
                }
                
                
            }
            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.ReadKey();
        }

    }
}
