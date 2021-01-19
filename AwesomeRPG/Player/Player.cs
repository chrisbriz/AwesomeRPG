using System;

namespace AwesomeRPG.Player
{
    abstract class Player : IPlayer
    {
        public int Hp { get; set; }
        public int Gold { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }
        public int Exp { get; set; }
        public int ExpToLevel { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public Random rnd { get; set; }

        virtual public int Attack(int dmg)
        {
            throw new NotImplementedException();
        }

        virtual public void TakeDamage()
        {
            throw new NotImplementedException();
        }


    }
}
