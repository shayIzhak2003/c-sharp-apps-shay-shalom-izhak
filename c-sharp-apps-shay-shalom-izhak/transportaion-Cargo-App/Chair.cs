using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportaion_Cargo_App
{
    public class Chair : Furniture
    {
        public bool HasArmrests { get; set; }
        public bool IsAdjustable { get; set; }

        // Constructor for Chair
        public Chair(decimal width, decimal length, decimal height, decimal weight, bool fragile, string material, string color, bool hasArmrests, bool isAdjustable)
            : base(width, length, height, weight, fragile, material, color)
        {
            HasArmrests = hasArmrests;
            IsAdjustable = isAdjustable;
        }
    }
}
