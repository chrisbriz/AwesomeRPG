using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Player
{
    class Mage : Player
    {
        public override int Attack(int dmg)
        {
            return base.Attack(dmg);
        }

        public override void TakeDamage()
        {
            base.TakeDamage();
        }
    }
}
