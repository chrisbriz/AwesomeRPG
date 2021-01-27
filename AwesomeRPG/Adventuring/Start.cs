using AwesomeRPG.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Adventuring
{
    class Start
    {
        public static IPlayer player;
        public static void GoAdventuring()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("* Welcome AwesomeTopia! *");
            Console.WriteLine("*************************");
            Console.WriteLine("");

            CreatePlayer();
            Console.Clear();
            Exploring.LetsGo();
            

            Console.ReadLine();


        }

        static void CreatePlayer()
        {

            Console.WriteLine("Choose a Class:");
            Console.WriteLine("1.Warrior");
            Console.WriteLine("2.Mage");
            Console.WriteLine("3.Ranger");

            var cki = Console.ReadKey();

            if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.NumPad1)
            {
                player = CharacterCreation.CreateWarrior();
            }
            else if (cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.NumPad2)
            {
                player = CharacterCreation.CreateMage();
            }
            else if (cki.Key == ConsoleKey.D3 || cki.Key == ConsoleKey.NumPad3)
            {
                player = CharacterCreation.CreateRanger();
            }
        }
    }
}
