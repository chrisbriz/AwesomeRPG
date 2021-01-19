using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Equipment
{
    interface IWeapons
    {
        int Price { get; set; }
        int level { get; set; }

        int ItemDamage(int baseDmg);
    }
}
