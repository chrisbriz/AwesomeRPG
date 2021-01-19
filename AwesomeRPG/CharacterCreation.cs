using AwesomeRPG.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG
{
    class CharacterCreation
    {
        public static Warrior newWarrior { get; set; }
        public static Mage newMage { get; set; }
        public static Ranger newRanger { get; set; }

        public static void CreatePlayer()
        {
            Console.WriteLine("Choose a Class:");
            Console.WriteLine("1.Warrior");
            Console.WriteLine("2.Mage");
            Console.WriteLine("3.Ranger");

            var cki = Console.ReadKey();

            if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.NumPad1)
            {
                newWarrior = CreateWarrior();
            }
            else if (cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.NumPad2)
            {
                newMage = CreateMage();
            }
            else if (cki.Key == ConsoleKey.D3 || cki.Key == ConsoleKey.NumPad3)
            {
                newRanger = CreateRanger();
            }
        }

        public static Warrior CreateWarrior()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
            Random rnd = new Random();
            Warrior newWarrior = new Warrior();
            newWarrior.Hp = rnd.Next(80, 120);
            newWarrior.Strength = rnd.Next(12, 15);
            newWarrior.Intelligence = rnd.Next(3, 5);
            newWarrior.Agility = rnd.Next(5, 8);
            newWarrior.Gold = 0;
            newWarrior.Exp = 0;
            newWarrior.ExpToLevel = 20;
            newWarrior.Level = 1;
            Console.Write("Enter your Name: ");
            newWarrior.Name = Console.ReadLine();
            

            return newWarrior;
        }

        public static Mage CreateMage()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
            Random rnd = new Random();
            Mage newMage = new Mage();
            newMage.Hp = rnd.Next(60, 100);
            newMage.Strength = rnd.Next(3, 5);
            newMage.Intelligence = rnd.Next(12, 15);
            newMage.Agility = rnd.Next(5, 8);
            newMage.Gold = 0;
            newMage.Exp = 0;
            newMage.ExpToLevel = 20;
            newMage.Level = 1;
            Console.Write("Enter your Name: ");
            newMage.Name = Console.ReadLine();


            return newMage;
        }

        public static Ranger CreateRanger()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
            Random rnd = new Random();
            Ranger newRanger = new Ranger();
            newRanger.Hp = rnd.Next(60, 100);
            newRanger.Strength = rnd.Next(3, 5);
            newRanger.Intelligence = rnd.Next(12, 15);
            newRanger.Agility = rnd.Next(5, 8);
            newRanger.Gold = 0;
            newRanger.Exp = 0;
            newRanger.ExpToLevel = 20;
            newRanger.Level = 1;
            Console.Write("Enter your Name: ");
            newRanger.Name = Console.ReadLine();


            return newRanger;
        }
    }
}
