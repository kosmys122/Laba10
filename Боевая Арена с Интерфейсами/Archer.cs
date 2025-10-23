using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Боевая_Арена_с_Интерфейсами
{
    internal class Archer :IUnit
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public Archer(string name)
        {
            Name = name;
            Health = 120;
        }
        public void Attack(IUnit target)
        {
            Console.WriteLine($"{Name} стреляет из лука {target.Name}!");
        }
    }
}
