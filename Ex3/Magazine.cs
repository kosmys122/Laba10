using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Magazine : IPrintable
    {
        public string Name { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"Название продукта {Name}");
        }
    }
}
