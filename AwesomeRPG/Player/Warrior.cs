using System;
using AwesomeRPG.Adventuring;
using System.Collections.Generic;
using System.Text;
using AwesomeRPG.Equipment;

namespace AwesomeRPG.Player
{
    class Warrior : Player
    {
        public override double Attack(IEquipable item)
        {
            var attack = 0;
            if (item == null)
            {
                attack = (int)Strength + 0;
            }
            else
            {
                attack = (int)Strength + item.StatType;
            }
            
            Random rnd = new Random();
            var damageModifier = rnd.Next(1, 3);

            var damage = damageModifier * attack;

            return damage;
        }

        public override IPlayer LevelUp(IPlayer player)
        {
            player.Level += 1;
            player.MaxHp *= 2;
            player.Hp = player.MaxHp;
            player.Strength = Math.Round(player.Strength * 1.9);
            player.Intelligence = Math.Round(player.Intelligence * 1.1);
            player.Agility = Math.Round(player.Agility * 1.4);
            player.Gold = player.Gold;
            player.Exp = player.Exp - player.ExpToLevel;
            player.ExpToLevel = player.ExpToLevel * 2;
            player.Class = player.Class;
            player.Name = player.Name;

            return player;
        }
    }
}
