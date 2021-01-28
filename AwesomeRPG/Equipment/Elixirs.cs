using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Equipment
{
    abstract class Elixirs : IConsumable
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Amount { get; set; }
        public virtual int Buff(int level)
        {
            return 5 * level;
        }
    }
}
