using AwesomeRPG.Adventuring;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace AwesomeRPG.Player
{
    class Mage : Player
    {
        //public Mage() : base() { }

        //public Mage(double hp,
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
            var attack = Intelligence;
            Random rnd = new Random();
            var damageModifier = rnd.Next(1, 3);

            var damage = damageModifier * attack;

            return damage;
        }

        public override IPlayer LevelUp(int exp, int expToLvl)
        {
            var player = Start.player;
            player.Level +=  1;
            player.MaxHp *= 2;
            player.Hp = player.MaxHp;
            player.Strength = Math.Round(player.Strength * 1.1f, 2);
            player.Intelligence = Math.Round(player.Intelligence * 2.1, 2);
            player.Agility = Math.Round(player.Agility * 1.3, 2);
            player.Gold = player.Gold;
            player.Exp = exp - expToLvl;
            player.ExpToLevel = player.ExpToLevel * 2;
            player.Class = player.Class;
            player.Name = player.Name;

            return player;
        }

        //public override void CheckCharacter(IPlayer player)
        //{
        //    Console.WriteLine($"Name: {player.Name}");
        //    Console.WriteLine($"Level: {player.Level}");
        //    Console.WriteLine($"Class: {player.Class}"); 
        //    Console.WriteLine($"Health: {player.Hp}"); 
        //    Console.WriteLine($"Max Health: {player.MaxHp}"); 
        //    Console.WriteLine($"Strenght: {player.Strength}"); 
        //    Console.WriteLine($"Intelligence: {player.Intelligence}"); 
        //    Console.WriteLine($"Agility: {player.Agility}"); 
        //    Console.WriteLine($"Gold: {player.Gold}"); 
        //    Console.WriteLine($"Experience: {player.Exp}"); 
        //    Console.WriteLine($"Next level: {player.ExpToLevel}");



        //    return string.Join("\r\n", player.GetType().GetProperties().Select(prop => prop.GetValue(player)));
        //}
    }
}
