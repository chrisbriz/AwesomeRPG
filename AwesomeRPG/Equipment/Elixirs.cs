using AwesomeRPG.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Equipment
{
    class Elixirs : IConsumable
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public virtual int Buff(int level)
        {
            return level;
        }

        public List<IConsumable> BuyStuff(List<IConsumable> stuff, IPlayer player)
        {
            throw new NotImplementedException();
        }
    }
}
