using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Equipment
{
    abstract class Weapons : IEquipable
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Damage { get; set; }
    }
}
