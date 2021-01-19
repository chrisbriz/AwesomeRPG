using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Equipment
{
    class Sword : IWeapons
    {
        public int Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int level { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int ItemDamage(int baseDmg)
        {
            throw new NotImplementedException();
        }
    }
}
