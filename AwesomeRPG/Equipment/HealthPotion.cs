using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Equipment
{
    class HealthPotion : Potions
    {
        public override int Restore(int level)
        {
            return base.Restore(level)*level;
        }
    }
}
