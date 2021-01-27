using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Enemies
{
    interface IMonster
    {
        double Hp { get; set; }
        int Armor { get; set; }
        string Name { get; set; }
        int Gold { get; set; }
        int Strength { get; set; }
        int Exp { get; set; }

        bool IsDead { get; set; }
        int Level { get; set; }
        Random Rnd { get; set; }

        int Attack(int dmg);
        int DropGold(int gold);

    }
}
