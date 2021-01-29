using AwesomeRPG.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Equipment
{
    interface IEquipable
    {
        string Name { get; set; }
        string Type { get; set; }
        int StatType { get; set; }
        int Price { get; set; }
        IEquipable BuyStuff(List<IEquipable> stuff, IPlayer player);
    }
}
