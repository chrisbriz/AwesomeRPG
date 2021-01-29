using AwesomeRPG.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Equipment
{
    class Weapons : IEquipable
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int StatType { get; set; }
        public int Price { get; set; }

        public IEquipable BuyStuff(List<IEquipable> stuff, IPlayer player)
        {
            IEquipable weapon = new Weapons();
            int count = 1;
            Console.Clear();
            foreach (var item in stuff)
            {                
                Console.WriteLine($"{count++}. {item.Name} (+ {item.StatType} damage) - {item.Price} gold");
            }

            Console.WriteLine("Not buying a weapon this time (press enter)");
            Console.WriteLine("");

            var cki = Console.ReadKey();

            switch (cki.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    {
                        weapon = stuff.Find(w => w.Name == "Short Sword");
                        break;
                    }

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    {
                        weapon = stuff.Find(w => w.Name == "Waraxe");
                        break;
                    }

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    {
                        weapon = stuff.Find(w => w.Name == "GreatSword");
                        break;
                    }

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    {
                        weapon = stuff.Find(w => w.Name == "Battle Axe");
                        break;
                    }

                default:
                    weapon = new Weapons { Name = "hands", Type = "Weapon", StatType = 0, Price = 0 };
                    break;
            }

            return weapon;
        }
    }
}
