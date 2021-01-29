using AwesomeRPG.Enemies;
using AwesomeRPG.Equipment;
using AwesomeRPG.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwesomeRPG.Adventuring
{
    class Exploring
    {
        private static bool lostGame, wonGame;
        public static List<IMonster> monstersList;
        public static IMonster monster;

        public static void LetsGo(IPlayer player)
        {


            Console.Clear();
            while (!wonGame && !lostGame)
            {
                Console.Clear();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1.Go on an adventure");
                Console.WriteLine("2.Check your character");
                Console.WriteLine("3.Go shopping");

                var cki = Console.ReadKey();

                if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.NumPad1)
                {
                    Console.Clear();
                    GoAdventuring(player);
                }
                else if (cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.NumPad2)
                {
                    Console.Clear();
                    player.CheckCharacter(player);
                }
                else if (cki.Key == ConsoleKey.D3 || cki.Key == ConsoleKey.NumPad3)
                {
                    Console.Clear();
                    player = Shop.Shopping(player);
                }
            }
            Console.WriteLine("Game Over, press enter to exit game");

            Console.ReadLine();
        }

        private static void GoAdventuring(IPlayer player)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
            Random rnd = new Random();
            int chanceOfEncounter = rnd.Next(101);

            if (chanceOfEncounter <= 10)
            {
                Console.Clear();
                Console.WriteLine("This stroll has been uneventfull");
                Console.WriteLine("Press enter to return to menu");

                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Fight(player);
            }
        }

        public static void Fight(IPlayer player)
        {
            Random rnd = new Random();
            CreateMonsters(player);


            //Select a monster appropriate for player level
            int index = rnd.Next(monstersList.Count);
            monster = monstersList[index];

            Console.WriteLine($"You encounter a {monster.Name}!");

            //Starts the Combat resolution
            while (monster.Hp > 0 && player.Hp > 0)
            {
                if (player.Hp < player.MaxHp && player.Consumable != null)
                {
                    Potions heal = new Potions();
                    Console.WriteLine("Do you wish to use a potion? y or n");
                    string usePotion = Console.ReadLine();
                    if (usePotion.ToUpper() == "Y")
                    {
                        heal.Restore(player);
                    //    IConsumable potion = player.Consumable.First();
                    //    player.Hp += potion.Amount;
                    //    if (player.Hp > player.MaxHp)
                    //    {
                    //        player.Hp = player.MaxHp;
                    //    }
                    //    player.Consumable.RemoveAt(0);
                    }
                }
                
                var playerDamage = player.Attack(player.Weapon);
                var monsterDamage = monster.Attack(monster.Strength);
                Console.WriteLine($"You attack and deal {playerDamage} damage!, {monster.Name} negates {monster.Armor} damage");
                monster.Hp -= playerDamage - monster.Armor;
                Console.WriteLine($"{monster.Name} has {monster.Hp} HP left");
                if (monster.Hp <= 0)
                {
                    Console.WriteLine("you won the fight!");
                    monster.Gold = monster.DropGold(monster.Level);
                    Console.WriteLine($"{monster.Name} yielded {monster.Exp} experience and dropped {monster.Gold} gold");
                    
                    player.Exp += monster.Exp;
                    player.Gold += monster.Gold;
                    Console.WriteLine($"you now have {player.Gold} gold");
                    if (player.Exp >= player.ExpToLevel)
                    {
                        player = player.LevelUp(player);
                        Console.WriteLine($"You gained a level! you are now level {player.Level}");

                        if (player.Level == 10)
                        {
                            wonGame = !wonGame;
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Press enter to continue");

                    Console.ReadLine();
                    break;
                }

                Console.WriteLine($"{monster.Name} attacks and deal {monsterDamage}, you negate {player.Armor.StatType} damage");
                player.Hp -= monsterDamage - player.Armor.StatType;
                Console.WriteLine($"You have {player.Hp} HP left");
                if (player.Hp <= 0)
                {
                    Console.WriteLine("You died...");
                    Console.WriteLine("Press enter to exit");
                    lostGame = !lostGame;
                    break;
                }
                Console.WriteLine("");
                Console.WriteLine("*******************************************************************");
                Console.ReadLine();
                
            }           
        }

        public static void CreateMonsters(IPlayer player)
        {
            List<IMonster> monsters = new List<IMonster>();

            if (Enumerable.Range(1, 3).Contains(player.Level))
            {
                monster = MonsterCreation.CreateBat(player);
                monsters.Add(monster);
                monster = MonsterCreation.CreateRat(player);
                monsters.Add(monster);
            }
            else if (Enumerable.Range(2, 4).Contains(player.Level))
            {
                monster = MonsterCreation.CreateBat(player);
                monsters.Add(monster);
                monster = MonsterCreation.CreateRat(player);
                monsters.Add(monster);
                monster = MonsterCreation.CreateWolf(player);
                monsters.Add(monster);
            }
            else if (Enumerable.Range(4, 8).Contains(player.Level))
            {
                monster = MonsterCreation.CreateBat(player);
                monsters.Add(monster);
                monster = MonsterCreation.CreateRat(player);
                monsters.Add(monster);
                monster = MonsterCreation.CreateWolf(player);
                monsters.Add(monster);
                monster = MonsterCreation.CreateGoblin(player);
                monsters.Add(monster);
            }
            else
            {
                monster = MonsterCreation.CreateBat(player);
                monsters.Add(monster);
                monster = MonsterCreation.CreateRat(player);
                monsters.Add(monster);
                monster = MonsterCreation.CreateWolf(player);
                monsters.Add(monster);
                monster = MonsterCreation.CreateGoblin(player);
                monsters.Add(monster);
                monster = MonsterCreation.CreateTroll(player);
                monsters.Add(monster);
            }

            monstersList = monsters;
        }
    }
}
