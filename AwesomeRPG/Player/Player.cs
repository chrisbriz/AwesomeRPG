using AwesomeRPG.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AwesomeRPG.Player
{
    abstract class Player : IPlayer
    {
        public double Hp { get; set; }
        public double MaxHp { get; set; }
        public int Gold { get; set; }
        public double Strength { get; set; }
        public double Intelligence { get; set; }
        public double Agility { get; set; }
        public int Exp { get; set; }
        public int ExpToLevel { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public List<IConsumable> Consumables { get; set; }
        public List<IEquipable> Equipements { get; set; }

        public virtual double Attack()
        {
            double damage = 1;
            return damage;
        }

        public virtual IPlayer LevelUp(int exp, int expToLvl)
        {
            return null;
        }

        public virtual void CheckCharacter(IPlayer player)
        {
            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine($"Level: {player.Level}");
            Console.WriteLine($"Class: {player.Class}");
            Console.WriteLine($"Health: {player.Hp}");
            Console.WriteLine($"Max Health: {player.MaxHp}");
            Console.WriteLine($"Strenght: {player.Strength}");
            Console.WriteLine($"Intelligence: {player.Intelligence}");
            Console.WriteLine($"Agility: {player.Agility}");
            Console.WriteLine($"Gold: {player.Gold}");
            Console.WriteLine($"Experience: {player.Exp}");
            Console.WriteLine($"Next level: {player.ExpToLevel}");
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
}
