using AwesomeRPG.Enemies;
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

        public static void LetsGo()
        {
            var player = Start.player;

            Console.Clear();
            while (!wonGame && !lostGame)
            {
                Console.Clear();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1.Go on an adventure");
                Console.WriteLine("2.Check your character");

                var cki = Console.ReadKey();

                if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.NumPad1)
                {
                    Console.Clear();
                    GoAdventuring();
                }
                else if (cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.NumPad2)
                {
                    Console.Clear();
                    player.CheckCharacter(player);

                }
            }
            Console.WriteLine("Game Over, press enter to return to character creation");
            Start.GoAdventuring();
        }

        private static void GoAdventuring()
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
            }
            else
            {
                Console.Clear();
                Fight();
            }
        }

        public static void Fight()
        {
            var player = Start.player;
            Random rnd = new Random();
            CreateMonsters();


            //Select a monster appropriate for player level
            int index = rnd.Next(monstersList.Count);
            monster = monstersList[index];

            Console.WriteLine($"You encounter a {monster.Name}!");

            //Starts the Combat resolution
            while (monster.Hp > 0 && player.Hp > 0)
            {
                var playerDamage = player.Attack();
                var monsterDamage = monster.Attack(monster.Strength);
                Console.WriteLine($"You attack and deal {playerDamage} damage!");
                monster.Hp -= playerDamage;
                Console.WriteLine($"{monster.Name} has {monster.Hp} HP left");
                if (monster.Hp <= 0)
                {
                    Console.WriteLine("you won the fight!");
                    Console.WriteLine($"{monster.Name} yielded {monster.Exp} and dropped {monster.Gold} gold");
                    player.Exp += monster.Exp;
                    player.Gold += monster.DropGold(monster.Level);
                    if (player.Exp >= player.ExpToLevel)
                    {
                        player = player.LevelUp(player.Exp, player.ExpToLevel);
                        Console.WriteLine($"You gained a level! you are now level {player.Level}");

                        if (player.Level == 10)
                        {
                            wonGame = !wonGame;
                        }
                    }
                    break;
                }

                Console.WriteLine($"{monster.Name} attacks and deal {monsterDamage}");
                player.Hp -= monsterDamage;
                Console.WriteLine($"You have {player.Hp} HP left");
                if (player.Hp <= 0)
                {
                    Console.WriteLine("You died...");
                    Console.WriteLine("Press enter to return to main menu");
                    lostGame = !lostGame;
                    break;
                }
                Console.WriteLine("");
                Console.WriteLine("*******************************************************************");
                Console.ReadLine();
                
            }

            

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
        }

        public static void CreateMonsters()
        {
            List<IMonster> monsters = new List<IMonster>();

            if (Enumerable.Range(1, 3).Contains(Start.player.Level))
            {
                monster = MonsterCreation.CreateBat();
                monsters.Add(monster);
                monster = MonsterCreation.CreateRat();
                monsters.Add(monster);
            }
            else if (Enumerable.Range(2, 4).Contains(Start.player.Level))
            {
                monster = MonsterCreation.CreateBat();
                monsters.Add(monster);
                monster = MonsterCreation.CreateRat();
                monsters.Add(monster);
                monster = MonsterCreation.CreateWolf();
                monsters.Add(monster);
            }
            else if (Enumerable.Range(4, 8).Contains(Start.player.Level))
            {
                monster = MonsterCreation.CreateBat();
                monsters.Add(monster);
                monster = MonsterCreation.CreateRat();
                monsters.Add(monster);
                monster = MonsterCreation.CreateWolf();
                monsters.Add(monster);
                monster = MonsterCreation.CreateGoblin();
                monsters.Add(monster);
            }
            else
            {
                monster = MonsterCreation.CreateBat();
                monsters.Add(monster);
                monster = MonsterCreation.CreateRat();
                monsters.Add(monster);
                monster = MonsterCreation.CreateWolf();
                monsters.Add(monster);
                monster = MonsterCreation.CreateGoblin();
                monsters.Add(monster);
                monster = MonsterCreation.CreateTroll();
                monsters.Add(monster);
            }

            monstersList = monsters;
        }
    }
}
