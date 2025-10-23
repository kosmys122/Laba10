using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Боевая_Арена_с_Интерфейсами
{
    internal class Arena
    {
        private List<IUnit> __units = new();
        public void AddUnit(IUnit unit)
        {
            __units.Add(unit);
        }
        public void StartBattle()
        {
            Console.WriteLine("Битва началась!");
            foreach (var attacker in __units)
            {
                foreach (var defender in __units)
                {
                    if (attacker != defender)
                        attacker.Attack(defender);
                }
            }
        }
    }
}
