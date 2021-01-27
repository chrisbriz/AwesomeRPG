using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Player
{
    class Warrior : Player
    {
        public override double Attack()
        {
            var attack = Strength;
            Random rnd = new Random();
            var damageModifier = rnd.Next(1, 3);

            var damage = damageModifier * attack;

            return damage;
        }

        public override IPlayer LevelUp(int exp, int expToLvl)
        {
            return base.LevelUp(exp, expToLvl);
        }
    }
}
