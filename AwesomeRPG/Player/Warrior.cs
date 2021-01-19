using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Player
{
    class Warrior : Player
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
