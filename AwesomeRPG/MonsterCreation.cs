using AwesomeRPG.Adventuring;
using AwesomeRPG.Enemies;
using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG
{
    class MonsterCreation
    {
        public static Bat CreateBat()
        {
            Random rnd = new Random();
            Bat newBat = new Bat();
            newBat.Level = rnd.Next(-3, 3) + Start.player.Level;
            if (newBat.Level <= 0)
            {
                newBat.Level = 1;
            }
            newBat.Name = "Bat";
            newBat.Hp = rnd.Next(30, 50) + Start.player.Level;
            newBat.Strength = rnd.Next(3, 7) + Start.player.Level;
            newBat.Armor = rnd.Next(0, 3) + Start.player.Level;
            newBat.Exp = Start.player.Level * newBat.Level + 20;

            return newBat;
        }

        public static Rat CreateRat()
        {
            Random rnd = new Random();
            Rat newRat = new Rat();
            newRat.Level = rnd.Next(-3, 5) + Start.player.Level;
            if (newRat.Level <= 0)
            {
                newRat.Level = 1;
            }
            newRat.Name = "Rat";
            newRat.Hp = rnd.Next(60, 80) + Start.player.Level;
            newRat.Strength = rnd.Next(7, 12) + Start.player.Level;
            newRat.Armor = rnd.Next(2, 4) + Start.player.Level;
            newRat.Exp = Start.player.Level * newRat.Level + 25;

            return newRat;
        }

        public static Wolf CreateWolf()
        {
            Random rnd = new Random();
            Wolf newWolf = new Wolf();
            newWolf.Level = rnd.Next(-3, 7) + Start.player.Level;
            if (newWolf.Level <= 0)
            {
                newWolf.Level = 1;
            }
            newWolf.Name = "Wolf";
            newWolf.Hp = rnd.Next(200, 240) + Start.player.Level;
            newWolf.Strength = rnd.Next(9, 15) + Start.player.Level;
            newWolf.Armor = rnd.Next(5, 7) + Start.player.Level;
            newWolf.Exp = Start.player.Level * newWolf.Level + 30;

            return newWolf;
        }

        public static Goblin CreateGoblin()
        {
            Random rnd = new Random();
            Goblin newGoblin = new Goblin();
            newGoblin.Level = rnd.Next(-3, 7) + Start.player.Level;
            if (newGoblin.Level <= 0)
            {
                newGoblin.Level = 1;
            }
            newGoblin.Name = "Goblin";
            newGoblin.Hp = rnd.Next(300, 400) + Start.player.Level;
            newGoblin.Strength = rnd.Next(12, 18) + Start.player.Level;
            newGoblin.Armor = rnd.Next(7, 9) + Start.player.Level;
            newGoblin.Exp = Start.player.Level * newGoblin.Level + 40;

            return newGoblin;
        }


        public static Troll CreateTroll()
        {
            Random rnd = new Random();
            Troll newTroll = new Troll();
            newTroll.Level = rnd.Next(6, 10) + Start.player.Level;
            if (newTroll.Level <= 0)
            {
                newTroll.Level = 1;
            }
            newTroll.Name = "Troll";
            newTroll.Hp = rnd.Next(500, 1000) + Start.player.Level;
            newTroll.Strength = rnd.Next(25, 30) + Start.player.Level;
            newTroll.Armor = rnd.Next(10, 15) + Start.player.Level;
            newTroll.Exp = Start.player.Level * newTroll.Level + 50;

            return newTroll;
        }
    }
}
