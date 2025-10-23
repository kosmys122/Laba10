using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Боевая_Арена_с_Интерфейсами
{
    internal class Warrior:IUnit
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public Warrior(string name)
        {
            Name = name;
            Health = 150;
        }
        public void Attack(IUnit target)
        {
            Console.WriteLine($"{Name} рубит мечом {target.Name}!");
        }
    }
}
