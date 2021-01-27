using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Player
{
    class Ranger : Player
    {
        public override double Attack()
        {
            return base.Attack();
        }

        public override IPlayer LevelUp(int exp, int expToLvl)
        {
            return base.LevelUp(exp, expToLvl);
        }
    }
}
