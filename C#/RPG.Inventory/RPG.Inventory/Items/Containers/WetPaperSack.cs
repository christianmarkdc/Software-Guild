using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Inventory.Items.Containers
{
    public class WetPaperSack : WeightRestrictedContainer
    {
        public WetPaperSack() : base(8,3)
        {
            Name = "Wet Paper Sack";
            Description = "Don't ask what happen to it. It is scarred";
            Weight = 2;
            Type = ItemType.Container;
        }
    }
}
