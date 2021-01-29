using AwesomeRPG.Equipment;
using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeRPG.Player
{
    interface IPlayer
    {
        string Name { get; set; }
        double Hp { get; set; }
        double MaxHp { get; set; }
        int Gold { get; set; }
        double Strength { get; set; }
        double Intelligence { get; set; }
        double Agility { get; set; }
        int Exp { get; set; }
        int ExpToLevel { get; set; }
        int Level { get; set; }
        string Class { get; set; }
        List<IConsumable> Consumable { get; set; }
        IEquipable Weapon { get; set; }
        IEquipable Armor { get; set; }


        double Attack(IEquipable item);

        IPlayer LevelUp(IPlayer player);
        void CheckCharacter(IPlayer player);
    }
}
