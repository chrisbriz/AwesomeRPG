using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Equipment
{
    interface IEquipable
    {
        string Name { get; set; }
        string Type { get; set; }
    }
}
