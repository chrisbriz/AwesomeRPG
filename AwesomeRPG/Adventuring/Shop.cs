using AwesomeRPG.Equipment;
using AwesomeRPG.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwesomeRPG.Adventuring
{
    class Shop
    {
        public static List<IEquipable> weapons = new List<IEquipable>();
        public static List<IEquipable> armors = new List<IEquipable>();
        public static List<IConsumable> consumables = new List<IConsumable>();

        public static IPlayer Shopping(IPlayer player)
        {
            weapons = CreateWeapons(player.Level);
            armors = CreateArmors(player.Level);
            consumables = CreateConsumables(player.Level);

            Console.WriteLine($"Welcome to my shop {player.Name}");
            Console.WriteLine("What do you want to purchase");
            Console.WriteLine($"you have {player.Gold} gold");
            IEquipable weapon = new Weapons();
            IEquipable armor = new Armors();
            IConsumable drink = new Potions();


            Console.WriteLine("1. A weapon");
            Console.WriteLine("2. An armor");
            Console.WriteLine("3. Some potions");
            Console.WriteLine("4. Nothing");


            var cki = Console.ReadKey();

            if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.NumPad1)
            {
                weapon = weapon.BuyStuff(weapons, player);
                if (player.Gold < weapon.Price)
                {
                    Console.WriteLine("you don't have enough gold, press enter to continue");
                }
                else
                {
                    player.Gold -= weapon.Price;
                    player.Weapon = weapon;
                    Console.WriteLine("Congratulation on your purchase, press enter to continue");
                }

                Console.ReadLine();
            }
            else if (cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.NumPad2)
            {
                armor = armor.BuyStuff(armors, player);
                if (player.Gold < armor.Price)
                {
                    Console.WriteLine("you don't have enough gold, press enter to continue");
                }
                else
                {
                    player.Gold -= armor.Price;
                    player.Armor = armor;
                    Console.WriteLine("Congratulation on your purchase, press enter to continue");
                }
                Console.WriteLine($"You have {player.Gold} gold left");
                Console.ReadLine();
            }
            else if (cki.Key == ConsoleKey.D3 || cki.Key == ConsoleKey.NumPad3)
            {
                int ownedPotions;
                if (player.Consumable != null)
                {
                    ownedPotions = player.Consumable.Count;
                }
                else
                {
                    ownedPotions = 0;
                }
                consumables = drink.BuyStuff(consumables, player);
                var total = consumables.Sum(item => item.Price);
                var potion = consumables.FirstOrDefault();
                var reduction = ownedPotions * potion.Price;
                var transactionPrice = total - reduction;
                if (player.Gold < transactionPrice)
                {
                    Console.WriteLine("you don't have enough gold, press enter to continue");
                }
                else
                {
                    player.Gold -= transactionPrice;
                    player.Consumable = consumables;
                    Console.WriteLine("Congratulation on your purchase, press enter to continue");
                }

                Console.ReadLine();
            }
            else if (cki.Key == ConsoleKey.D4 || cki.Key == ConsoleKey.NumPad4)
            {
                Console.WriteLine("");
            }

            return player;
        }

        public static List<IEquipable> CreateWeapons(int level)
        {
            List<IEquipable> weapons = new List<IEquipable>();

            IEquipable shortSword = new Weapons
            {
                Name = "Short Sword",
                Type = "Weapon",
                StatType = 7 * level,
                Price = 30 * level
            };
            weapons.Add(shortSword);

            IEquipable axe = new Weapons
            {
                Name = "Waraxe",
                Type = "Weapon",
                StatType = 10 * level,
                Price = 45 * level
            };
            weapons.Add(axe);

            IEquipable greatSword = new Weapons
            {
                Name = "GreatSword",
                Type = "Weapon",
                StatType = 20 * level,
                Price = 130 * level
            };
            weapons.Add(greatSword);

            IEquipable battleAxe = new Weapons
            {
                Name = "Battle Axe",
                Type = "Weapon",
                StatType = 30 * level,
                Price = 200 * level
            };
            weapons.Add(battleAxe);

            return weapons;
        }

        public static List<IEquipable> CreateArmors(int level)
        {
            List<IEquipable> armors = new List<IEquipable>();

            IEquipable leatherVest = new Armors
            {
                Name = "Leather vest",
                Type = "Armor",
                StatType = 8 * level,
                Price = 30 * level
            };
            armors.Add(leatherVest);

            IEquipable robe = new Armors
            {
                Name = "Robe",
                Type = "Armor",
                StatType = 5 * level,
                Price = 45 * level
            };
            armors.Add(robe);

            IEquipable chainMail = new Armors
            {
                Name = "ChainMail",
                Type = "Armor",
                StatType = 12 * level,
                Price = 130 * level
            };
            armors.Add(chainMail);

            return armors;
        }

        public static List<IConsumable> CreateConsumables(int level)
        {
            List<IConsumable> drinks = new List<IConsumable>();

            IConsumable hpPotion = new Potions
            {
                Name = "Health Potion",
                Type = "Consumable",
                Amount = 20 * level,
                Price = 20
            };
            drinks.Add(hpPotion);

            return drinks;
        }

        //public T InstantiateType<T>(string name, string type) where T : IEquipable, new()
        //{
        //    T obj = new T();
        //    obj.Name = name;
        //    obj.Type = type;
        //    return obj;
        //}
    }
}
