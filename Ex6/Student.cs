using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Student : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void GetDescription()
        {
            Console.WriteLine($"Имя студента {Name}, его возраст {Age}");
        }
    }
}
