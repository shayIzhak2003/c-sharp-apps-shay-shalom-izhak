using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportaion_Cargo_App
{
    public class ShippingPriceCalculator : IShippingPriceCalculator
{
    private const decimal TrainRate = 5m;
    private const decimal ShipRate = 20m;
    private const decimal PlaneRate = 50m;

    public decimal CalculatePrice(IPortable item, int travelDistance)
    {
        int units = (int)(item.GetVolume() / 100) + (int)item.GetWeight();
        if (item.IsFragile())
        {
            units *= 2;
        }

        decimal rate = GetRate(item);
        return units * travelDistance * rate;
    }

    public decimal CalculatePrice(List<IPortable> items, int travelDistance)
    {
        decimal totalPrice = 0;
        foreach (var item in items)
        {
            totalPrice += CalculatePrice(item, travelDistance);
        }
        return totalPrice;
    }


        private decimal GetRate(IPortable item)
        {
            // Determine the rate based on the type of item or other criteria
            // Here, we'll use a simple example based on cargo type

            if (item is ElectricItem)
            {
                // Assuming ElectricItem should use a specific rate
                return TrainRate;
            }

            switch (item.CargoType)
            {
                case CargoType.Train:
                    return TrainRate;
                case CargoType.Ship:
                    return ShipRate;
                case CargoType.Plane:
                    return PlaneRate;
                default:
                    throw new ArgumentException("Unknown cargo type");
            }
        }
    }

}
