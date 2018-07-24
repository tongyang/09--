using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承练习
{
    class Reporter : Person
    {
        private string _habbit;
        public string Habbit { get => _habbit; set => _habbit = value; }

        public Reporter(int age, string name, string habbit) : base(age, name)
        {
            this.Habbit = habbit;
        }

        public void SayHello(string name, string habbit)
        {
            Console.WriteLine("大家好，我叫{0}，我的爱好是{1}", name, habbit);
        }
    }
}
