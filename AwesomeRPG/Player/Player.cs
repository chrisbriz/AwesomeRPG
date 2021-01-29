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
        public IEquipable Weapon { get; set; }
        public IEquipable Armor { get; set; }
        public List<IConsumable> Consumable { get; set; }

        public virtual double Attack(IEquipable item)
        {
            double damage = 1;
            return damage;
        }

        public virtual IPlayer LevelUp(IPlayer player)
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
            Console.WriteLine($"Weapon: {player.Weapon.Name}");
            Console.WriteLine($"---Damage: {player.Weapon.StatType}");
            Console.WriteLine($"Armor: {player.Armor.Name}");
            Console.WriteLine($"---Damage Reduction: {player.Armor.StatType}");
            int count = 0;
            IConsumable healthPotion = new Potions();
            if (player.Consumable != null)
            {                
                foreach (var item in player.Consumable)
                {
                    count++;
                }
                healthPotion = player.Consumable.Find(x => x.Name == "Health Potion");
                Console.WriteLine($"{healthPotion.Name} x {count}");
            }
            else
            {
                Console.WriteLine("you have no potions");
            }            
            Console.WriteLine($"Gold: {player.Gold}");
            Console.WriteLine($"Experience: {player.Exp}");
            Console.WriteLine($"Next level: {player.ExpToLevel}");
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
}
