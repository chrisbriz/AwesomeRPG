using System;

namespace AwesomeRPG.Player
{
    abstract class Player : IPlayer
    {
        public double Hp { get; set; }
        public double MaxHp { get; set; }
        public int Gold { get; set; }
        public double Strength { get; set; }
        public double Intelligence { get; set; }
        public double Agility { get; set; }
        public int Exp { get; set; }
        public int ExpToLevel { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public Random rnd { get; set; }
        public string Class { get; set; }
        public IPlayer player { get; set; }

        public virtual double Attack()
        {
            double damage = 1;
            return damage;
        }

        public virtual IPlayer LevelUp(int exp, int expToLvl)
        {
            return null;
        }
    }
}
