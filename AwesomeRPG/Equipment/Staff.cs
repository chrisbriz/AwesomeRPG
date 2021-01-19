using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Equipment
{
    class Staff : IWeapons
    {
        public int Price { get; set; }
        public int level { get; set; }

        public int ItemDamage(int baseDmg)
        {
            throw new NotImplementedException();
        }
    }
}
