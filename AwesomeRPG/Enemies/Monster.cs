using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Enemies
{
    abstract class Monster : IMonster
    {
        public int Hp { get; set; }
        public int Armor { get; set; }
        public string Name { get; set; }
        public int Gold { get; set; }
        public int Strength { get; set; }
        public int Exp { get; set; }
        public Random Rnd { get; set; }
        public bool IsDead { get; set; }

        virtual public int Attack(int dmg)
        {
            throw new NotImplementedException();
        }

        virtual public void DropGold()
        {
            throw new NotImplementedException();
        }

        virtual public void TakeDamage()
        {
            throw new NotImplementedException();
        }
    }
}
