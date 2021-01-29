using AwesomeRPG.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Equipment
{
    interface IConsumable
    {
        string Name { get; set; }
        string Type { get; set; }
        int Amount { get; set; }
        int Price { get; set; }
        List<IConsumable> BuyStuff(List<IConsumable> stuff, IPlayer player);

    }
}
