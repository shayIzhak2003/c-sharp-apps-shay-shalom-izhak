using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportaion_Cargo_App
{
    public class Table : Furniture
    {
        public int NumberOfLegs { get; set; }
        public bool IsExtendable { get; set; }

        // Constructor for Table
        public Table(decimal width, decimal length, decimal height, decimal weight, bool fragile, string material, string color, int numberOfLegs, bool isExtendable)
            : base(width, length, height, weight, fragile, material, color)
        {
            NumberOfLegs = numberOfLegs;
            IsExtendable = isExtendable;
        }
    }
}
