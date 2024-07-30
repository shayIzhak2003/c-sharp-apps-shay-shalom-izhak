using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportaion_Cargo_App
{
    public abstract class Furniture : GenericItem
    {
        public string Material { get; set; }
        public string Color { get; set; }

        // Constructor for Furniture
        public Furniture(decimal width, decimal length, decimal height, decimal weight, bool fragile, string material, string color)
        {
            Width = width;
            Length = length;
            Height = height;
            Weight = weight;
            Fragile = fragile;
            Material = material;
            Color = color;
        }
    }

}
