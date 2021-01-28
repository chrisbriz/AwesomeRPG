using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Equipment
{
    abstract class Potions : IConsumable
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Amount { get; set; }
        public virtual int Restore(int level)
        {
            return 50;
        }
    }
}
