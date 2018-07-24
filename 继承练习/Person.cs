using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承练习
{
    class Person
    {
        private int _age;
        private string _name;

        public int Age { get => _age; set => _age = value; }
        public string Name { get => _name; set => _name = value; }

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
    }
}
