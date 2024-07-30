using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportaion_Cargo_App
{
    public class Sofa : Furniture
    {
        public int SeatingCapacity { get; set; }
        public bool HasStorage { get; set; }

        // Constructor for Sofa
        public Sofa(decimal width, decimal length, decimal height, decimal weight, bool fragile, string material, string color, int seatingCapacity, bool hasStorage)
            : base(width, length, height, weight, fragile, material, color)
        {
            SeatingCapacity = seatingCapacity;
            HasStorage = hasStorage;
        }
    }
}
