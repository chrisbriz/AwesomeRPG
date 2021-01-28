using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Equipment
{
    abstract class Armors : IEquipable
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Armor { get; set; }
    }
}
