using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class Person
    {
        public int _age;
        private string _gender;
        private string _name;

        public string Name { get => _name; set => _name = value; }
        public string Gender { get => _gender; set => _gender = value; }

        public Person(int age, string name, string gender)
        {
            this._age = age;
            this.Name = name;
            this.Gender = gender;
        }

        

    }
}
