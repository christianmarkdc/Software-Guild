using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Inventory.Items.Armor
{
    public class TurtleArmor : Item
    {
        public TurtleArmor()
        {
            Name = "Turtle Armor";
            Description = "Its the legendary Turtle Armor that the gods use to have";
            Weight = 3;
            Type = ItemType.Armor;
        }
    }
}
