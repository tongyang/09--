using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class Student : Person
    {
        public char _sex;

        public Student(int age, string name, char sex, string gender) : base(age, name, gender)
        {
            this._sex = sex;
        }
    }
}
