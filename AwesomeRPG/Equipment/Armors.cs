using AwesomeRPG.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Equipment
{
    class Armors : IEquipable
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int StatType { get; set; }
        public int Price { get; set; }

        public IEquipable BuyStuff(List<IEquipable> stuff, IPlayer player)
        {
            IEquipable armor = new Armors();
            int count = 1;
            Console.Clear();
            foreach (var item in stuff)
            {                
                Console.WriteLine($"{count++}. {item.Name} (+ {item.StatType} armor) - {item.Price} gold");
            }

            Console.WriteLine("");

            var cki = Console.ReadKey();

            switch (cki.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    {
                        armor = stuff.Find(w => w.Name == "Leather vest");
                        break;
                    }

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    {
                        armor = stuff.Find(w => w.Name == "Robe");
                        break;
                    }

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    {
                        armor = stuff.Find(w => w.Name == "ChainMail");
                        break;
                    }

                default:
                    armor = new Armors { Name = "Apron", Type = "Armor", StatType = 0, Price = 0 };
                    break;
            }

            return armor;
        }
    }
}
