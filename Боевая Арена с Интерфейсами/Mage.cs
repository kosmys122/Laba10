using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Боевая_Арена_с_Интерфейсами
{
    internal class Mage: IUnit
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public Mage(string name)
        {
            Name = name;
            Health = 100;
        }
        public void Attack(IUnit target)
        {
            Console.WriteLine($"{Name} машет посохом {target.Name}!");
        }
    }
}
