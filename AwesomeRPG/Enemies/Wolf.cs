using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Enemies
{
    class Wolf : Monster
    {
        public override int Attack(int dmg)
        {
            return base.Attack(dmg);
        }

        public override int DropGold(int level)
        {
            return base.DropGold(level) + 15;
        }
    }
}
