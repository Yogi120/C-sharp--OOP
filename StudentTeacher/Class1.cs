using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher
{
    class Person
    {
        public int Age;
        public void SetAge(int n)
        {
            Age = n;
        }

        public void Greet()
        {
            Console.WriteLine("Hello");
        }
    }
}
