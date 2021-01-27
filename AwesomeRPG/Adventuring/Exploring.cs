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
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1.Go on an adventure");
                Console.WriteLine("2.Check your character");

                var cki = Console.ReadKey();

                if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.NumPad1)
                {
                    GoAdventuring();
                }
                else if (cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.NumPad2)
                {
                    CheckCharacter();
                }
            }
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
                Console.WriteLine("This stroll has been uneventfull");
            }
            else
            {
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

            Console.WriteLine($"You encounter a {monster.Name}");

            //Starts the Combat resolution
            while (monster.Hp > 0 && player.Hp > 0)
            {
                var playerDamage = player.Attack();
                var monsterDamage = monster.Attack(monster.Strength);
                Console.WriteLine($"You attack and deal {playerDamage} damage!");
                monster.Hp -= playerDamage;
                Console.ReadLine();

                Console.WriteLine($"{monster.Name} attacks and deal {monsterDamage}");
                player.Hp -= monsterDamage;
                Console.ReadLine();
            }

            if (monster.Hp <= 0)
            {
                Console.WriteLine("you won the fight!");
                player.Exp += monster.Exp;
                if (player.Exp >= player.ExpToLevel)
                {
                    player = player.LevelUp(player.Exp, player.ExpToLevel);
                }
            }
            else if (player.Hp <= 0)
            {
                Console.WriteLine("You died...");
            }

            Console.ReadLine();
        }

        private static void CheckCharacter()
        {
            throw new NotImplementedException();
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
