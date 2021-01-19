using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Player
{
    interface IPlayer
    {
        string Name { get; set; }
        int Hp { get; set; }
        int Gold { get; set; }
        int Strength { get; set; }
        int Intelligence { get; set; }
        int Agility { get; set; }
        int Exp { get; set; }
        int ExpToLevel { get; set; }
        int Level { get; set; }
        Random rnd { get; set; }
        
        
        int Attack(int dmg);

        void TakeDamage();


    }
}
