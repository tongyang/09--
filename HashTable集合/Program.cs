using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable集合
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("姓名", "童扬");
            ht.Add("性别", '男');
            ht.Add("年龄", 29);
            ht.Add("爱好", "篮球");

            if (ht.ContainsKey("年级"))
            {
                ht["年级"] = "三年级";
            }
            else
            {
                ht.Add("年级", "三年级");
            }

            foreach (var item in ht.Keys)
            {
                Console.WriteLine(ht[item]);
            }
            Console.ReadKey();
        }
    }
}
