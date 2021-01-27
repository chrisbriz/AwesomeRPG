using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Player
{
    interface IPlayer
    {
        IPlayer player { get; set; }
        string Name { get; set; }
        double Hp { get; set; }
        double MaxHp { get; set; }
        int Gold { get; set; }
        double Strength { get; set; }
        double Intelligence { get; set; }
        double Agility { get; set; }
        int Exp { get; set; }
        int ExpToLevel { get; set; }
        int Level { get; set; }
        Random rnd { get; set; }
        string Class { get; set; }



        double Attack();

        IPlayer LevelUp(int exp, int expToLvl);
    }
}
