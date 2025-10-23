using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Боевая_Арена_с_Интерфейсами
{
    internal interface IUnit
    {
        string Name { get; }
        int Health { get; }
        void Attack(IUnit target);
    }
}
