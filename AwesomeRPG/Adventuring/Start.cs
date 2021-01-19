using AwesomeRPG.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Adventuring
{
    public class Start
    {
        private bool lostGame, wonGame;
        
        public static void GoAdventuring()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("* Welcome AwesomeTopia! *");
            Console.WriteLine("*************************");
            Console.WriteLine("");

            CharacterCreation.CreatePlayer();


            

            Console.ReadLine();
        }
    }
}
