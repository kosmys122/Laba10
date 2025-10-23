using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Teacher : IPerson
    {
        public string Name { get; set; }
        public string Kaf { get; set; }
        public void GetDescription()
        {
            Console.WriteLine($"Имя преподавателя {Name}, его кафедра {Kaf}");
        }
    }
}
