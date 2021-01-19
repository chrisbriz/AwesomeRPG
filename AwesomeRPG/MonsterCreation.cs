using AwesomeRPG.Enemies;
using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG
{
    class MonsterCreation
    {
        public Bat newBat { get; set; }
        public Rat newRat { get; set; }
        public Goblin newGoblin { get; set; }
        public Troll newTroll { get; set; }

        public static void CreateBat()
        {
            Random rnd = new Random();
            Bat newBat = new Bat();
            newBat.Hp = rnd.Next(10, 20);
            newBat.Strength = rnd.Next(3, 7);
            newBat.Armor = rnd.Next(0, 3);
        }

        public static void CreateRat()
        {
            Random rnd = new Random();
            Rat newRat = new Rat();
            newRat.Hp = rnd.Next(20, 30);
            newRat.Strength = rnd.Next(7, 12);
            newRat.Armor = rnd.Next(2, 4);
        }

        public static void CreateGoblin()
        {
            Random rnd = new Random();
            Goblin newGoblin = new Goblin();
            newGoblin.Hp = rnd.Next(30, 40);
            newGoblin.Strength = rnd.Next(12, 15);
            newGoblin.Armor = rnd.Next(5, 7);
        }

        public static void CreateTroll()
        {
            Random rnd = new Random();
            Troll newTroll = new Troll();
            newTroll.Hp = rnd.Next(100, 150);
            newTroll.Strength = rnd.Next(25, 30);
            newTroll.Armor = rnd.Next(10, 15);
        }
    }
}
