using AwesomeRPG.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwesomeRPG.Equipment
{
    class Potions : IConsumable
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }

        public virtual void Restore(IPlayer player)
        {
            IConsumable potion = player.Consumable.First();
            player.Hp += potion.Amount;
            if (player.Hp > player.MaxHp)
            {
                player.Hp = player.MaxHp;
            }
            player.Consumable.RemoveAt(0);
            Console.WriteLine($"you now have {player.Hp} hp");

            Console.ReadLine();
        }

        public List<IConsumable> BuyStuff(List<IConsumable> stuff, IPlayer player)
        {
            IConsumable drink = new Potions();
            List<IConsumable> potions = new List<IConsumable>();
            bool open = true;
            int count = 1;
            int ownedPotions;
            Console.Clear();
            if (player.Consumable != null)
            {
                ownedPotions = player.Consumable.Count;                
            }
            else
            {
                ownedPotions = 0;
            }
            Console.WriteLine($"You currently have {ownedPotions} potions out of 5");

            do
            {
                Console.Clear();
                foreach (var item in stuff)
                {
                    Console.WriteLine($"{count++}. {item.Name} for {item.Price} gold");
                }
                Console.WriteLine($"You have {potions.Count} health potions out of 5");
                Console.WriteLine("press 0 to leave");
                Console.WriteLine("");
                var cki = Console.ReadKey();

                switch (cki.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        {
                            drink = stuff.Find(w => w.Name == "Health Potion");
                            potions.Add(drink);
                            break;
                        }
                    case ConsoleKey.D0:
                    case ConsoleKey.NumPad0:
                        {
                            open = false;
                            break;
                        }
                }
            } while (open == true && potions.Count < 5);  


            return potions;
        }
        
    }
}

