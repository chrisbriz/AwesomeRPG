using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Enemies
{
    class Troll : Monster
    {
        public override int Attack(int dmg)
        {
            return base.Attack(dmg);
        }

        public override void DropGold()
        {
            base.DropGold();
        }

        public override void TakeDamage()
        {
            base.TakeDamage();
        }

    }
}
