using System;
using AwesomeRPG.Adventuring;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Player
{
    class Ranger : Player
    {
        //public Ranger() : base() { }

        //public Ranger(double hp,
        //    double maxHp,
        //    int gold,
        //    double str,
        //    double intel,
        //    double agi,
        //    int xp,
        //    int xpToLvl,
        //    string name,
        //    string charClass) : base(hp,
        //    maxHp,
        //    gold,
        //    str,
        //    intel,
        //    agi,
        //    xp,
        //    xpToLvl,
        //    name,
        //    charClass)
        //{ }

        public override double Attack()
        {
            var attack = Agility;
            Random rnd = new Random();
            var damageModifier = rnd.Next(1, 3);

            var damage = damageModifier * attack;

            return damage;
        }

        public override IPlayer LevelUp(int exp, int expToLvl)
        {
            var player = Start.player;
            player.Level += 1;
            player.MaxHp *= 2;
            player.Hp = player.MaxHp;
            player.Strength = Math.Round(player.Strength * 1.5f, 2);
            player.Intelligence = Math.Round(player.Intelligence * 1.5, 2);
            player.Agility = Math.Round(player.Agility * 1.9, 2);
            player.Gold = player.Gold;
            player.Exp = exp - expToLvl;
            player.ExpToLevel = player.ExpToLevel * 2;
            player.Class = player.Class;
            player.Name = player.Name;

            return player;
        }
    }
}
