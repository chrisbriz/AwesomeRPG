using AwesomeRPG.Adventuring;
using AwesomeRPG.Equipment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace AwesomeRPG.Player
{
    class Mage : Player
    {
        public override double Attack(IEquipable item)
        {
            if (item == null)
            {
                item.Name = string.Empty;
                item.Price = 0;
                item.StatType = 0;
                item.Type = "Hands";
            }
            var attack = Intelligence + item.StatType;
            Random rnd = new Random();
            var damageModifier = rnd.Next(1, 3);

            var damage = damageModifier * attack;

            return damage;
        }

        public override IPlayer LevelUp(IPlayer player)
        {
            player.Level +=  1;
            player.MaxHp *= 2;
            player.Hp = player.MaxHp;
            player.Strength = Math.Round(player.Strength * 1.1);
            player.Intelligence = Math.Round(player.Intelligence * 2.1);
            player.Agility = Math.Round(player.Agility * 1.3);
            player.Gold = player.Gold;
            player.Exp = player.Exp - player.ExpToLevel;
            player.ExpToLevel = player.ExpToLevel * 2;
            player.Class = player.Class;
            player.Name = player.Name;

            return player;
        }
    }
}
