using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承练习
{
    class Driver : Person
    {
        public Driver(string name, int age) : base(age, name)
        {

        }

        public new void Test()
        {
            Console.WriteLine("哈哈哈");
        }
    }
}
