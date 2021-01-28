using AwesomeRPG.Player;
using AwesomeRPG.Adventuring;
using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG
{
    class CharacterCreation
    {
        public static Warrior CreateWarrior()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
            Random rnd = new Random();
            Warrior newWar = new Warrior();
            newWar.Hp = rnd.Next(80, 120);
            newWar.MaxHp = newWar.Hp;
            newWar.Strength = rnd.Next(12, 15);
            newWar.Intelligence = rnd.Next(3, 5);
            newWar.Agility = rnd.Next(5, 8);
            newWar.Gold = 0;
            newWar.Exp = 0;
            newWar.Level = 1;
            newWar.ExpToLevel = 20 * newWar.Level;
            newWar.Class = "Warrior";
            Console.Write("Enter your Name: ");
            newWar.Name = Console.ReadLine();
            

            return newWar;
        }

        public static Mage CreateMage()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
            Random rnd = new Random();
            Mage newMage = new Mage();
            newMage.Hp = rnd.Next(60, 100);
            newMage.MaxHp = newMage.Hp;
            newMage.Strength = rnd.Next(3, 5);
            newMage.Intelligence = rnd.Next(12, 15);
            newMage.Agility = rnd.Next(5, 8);
            newMage.Gold = 0;
            newMage.Exp = 0;
            newMage.ExpToLevel = 20;
            newMage.Level = 1;
            newMage.Class = "Mage";
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
            newRanger.MaxHp = newRanger.Hp;
            newRanger.Strength = rnd.Next(3, 5);
            newRanger.Intelligence = rnd.Next(5, 8);
            newRanger.Agility = rnd.Next(12, 15);
            newRanger.Gold = 0;
            newRanger.Exp = 0;
            newRanger.ExpToLevel = 20;
            newRanger.Level = 1;
            newRanger.Class = "Ranger";
            Console.Write("Enter your Name: ");
            newRanger.Name = Console.ReadLine();


            return newRanger;
        }
    }
}
