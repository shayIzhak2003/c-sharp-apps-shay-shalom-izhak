using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportaion_Cargo_App
{
    public class ElectricItem : GenericItem
    {
        public int PowerConsumption { get; set; } // in watts
        public string Brand { get; set; }
        public string Model { get; set; }

        // Example of an overridden method
        public override decimal GetWeight()
        {
            // Adding some specific logic for ElectricItem
            return base.GetWeight() + (PowerConsumption / 1000m); // Assuming weight increases slightly with power consumption
        }

        // Constructor
        public ElectricItem(decimal width, decimal length, decimal height, decimal weight, bool fragile, int powerConsumption, string brand, string model)
        {
            Width = width;
            Length = length;
            Height = height;
            Weight = weight;
            Fragile = fragile;
            PowerConsumption = powerConsumption;
            Brand = brand;
            Model = model;
        }
    }
}
