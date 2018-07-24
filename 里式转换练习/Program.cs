using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里式转换练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] ps = new Person[5];
            Random r = new Random();
            for (int i = 0; i < ps.Length; i++)
            {
                int rNum = r.Next(1, 6);
                switch (rNum)
                {
                    case 1:
                        ps[i] = new Teacher();
                        break;
                    case 2:
                        ps[i] = new Animal();
                        break;
                    case 3:
                        ps[i] = new Shuaiguo();
                        break;
                    case 4:
                        ps[i] = new Meinv();
                        break;
                    default:
                        ps[i] = new Person();
                        break;
                }
            }
            foreach (Person p in ps)
            {
                if (p is Teacher)
                {
                    ((Teacher)p).TeacherSayHi();
                }
                else if (p is Animal)
                {
                    ((Animal)p).AnimalSayHi();
                }
                else if (p is Shuaiguo)
                {
                    ((Shuaiguo)p).ShuaiGuoSayHi();
                }
                else if (p is Meinv)
                {
                    ((Meinv)p).MeinvSayHi();
                }
                else
                {
                    p.SayHi();
                }
            }
            Console.ReadKey();
        }
    }
}
