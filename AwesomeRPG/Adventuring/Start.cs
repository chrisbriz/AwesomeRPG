using AwesomeRPG.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Adventuring
{
    class Start
    {
        private static IPlayer _player;

        public Start(IPlayer player)
        {
            _player = player;
        }

        public static void GoAdventuring()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("* Welcome AwesomeTopia! *");
            Console.WriteLine("*************************");
            Console.WriteLine("");

            CreatePlayer();
            if (_player == null)
            {
                Environment.Exit(0);
            }
            Console.Clear();
            Exploring.LetsGo(_player);
         
        }

        static void CreatePlayer()
        {

            Console.WriteLine("Choose a Class:");
            Console.WriteLine("1.Warrior");
            Console.WriteLine("2.Mage");
            Console.WriteLine("3.Ranger");
            Console.WriteLine("0.Exit Game");

            var cki = Console.ReadKey();

            if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.NumPad1)
            {
                _player = CharacterCreation.CreateWarrior();
            }
            else if (cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.NumPad2)
            {
                _player = CharacterCreation.CreateMage();
            }
            else if (cki.Key == ConsoleKey.D3 || cki.Key == ConsoleKey.NumPad3)
            {
                _player = CharacterCreation.CreateRanger();
            }
            else if (cki.Key == ConsoleKey.D4 || cki.Key == ConsoleKey.NumPad4)
            {
                _player = null;
            }
        }
    }
}
