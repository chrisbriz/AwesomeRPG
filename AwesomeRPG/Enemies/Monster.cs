using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Enemies
{
    abstract class Monster : IMonster
    {
        public double Hp { get; set; }
        public int Armor { get; set; }
        public string Name { get; set; }
        public int Gold { get; set; }
        public int Strength { get; set; }
        public int Exp { get; set; }
        public int Level { get; set; }
        public bool IsDead { get; set; }

        virtual public int Attack(int dmg)
        {
            int attack = Strength;
            Random rnd = new Random();
            int damageModifier = rnd.Next(1, 3);

            int damage = damageModifier * attack;

            return damage;
        }

        virtual public int DropGold(int level)
        {
            int baseGold = 40 * level;
            return baseGold; 
        }
    }
}
