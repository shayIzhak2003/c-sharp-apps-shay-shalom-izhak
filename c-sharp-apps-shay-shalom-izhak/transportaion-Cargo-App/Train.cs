using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportaion_Cargo_App
{
    public class Train : CargoVehicle
    {
        private Cron cargoLimiter;

        public Train(decimal maxVolume, decimal maxWeight)
        {
            cargoLimiter = new Cron(maxVolume, maxWeight);
        }

        public override bool Load(IPortable item)
        {
            if (cargoLimiter.AddItem(item))
            {
                ItemsToLoad.Add(item);
                item.PackageItem();
                return true;
            }
            return false;
        }

        public override bool Load(List<IPortable> items)
        {
            foreach (var item in items)
            {
                if (!Load(item))
                {
                    return false;
                }
            }
            return true;
        }

        public override bool UnLoad()
        {
            if (ItemsToLoad.Count > 0)
            {
                foreach (var item in ItemsToLoad.ToList())
                {
                    cargoLimiter.RemoveItem(item);
                    ItemsToLoad.Remove(item);
                }
                return true;
            }
            return false;
        }

        public override bool UnLoad(IPortable item)
        {
            if (ItemsToLoad.Contains(item))
            {
                ItemsToLoad.Remove(item);
                cargoLimiter.RemoveItem(item);
                item.UnPackage();
                return true;
            }
            return false;
        }

        public override bool UnLoad(List<IPortable> items)
        {
            foreach (var item in items)
            {
                if (!UnLoad(item))
                {
                    return false;
                }
            }
            return true;
        }

        public override bool IsHaveRoom()
        {
            return !cargoLimiter.IsOverloaded();
        }

        public override bool IsOverload()
        {
            return cargoLimiter.IsOverloaded();
        }

        public override decimal GetMaxVolume()
        {
            return cargoLimiter.MaxVolume;
        }

        public override decimal GetMaxWeight()
        {
            return cargoLimiter.MaxWeight;
        }

        public override decimal GetCurrentVolume()
        {
            return cargoLimiter.GetCurrentVolume();
        }

        public override decimal GetCurrentWeight()
        {
            return cargoLimiter.GetCurrentWeight();
        }

        public override string GetPricingList()
        {
            StringBuilder pricingList = new StringBuilder();
            pricingList.AppendLine("Pricing List for Train Transportation:");
            decimal totalPrice = 0;

            foreach (var item in ItemsToLoad)
            {
                decimal price = PriceCalculator.CalculatePrice(item, DistanceToNextPort);
                totalPrice += price;
                pricingList.AppendLine($"Item: {item.GetType().Name}, Volume: {item.GetVolume()} m³, Weight: {item.GetWeight()} kg, Price: {price:C}");
            }

            pricingList.AppendLine($"Total Price: {totalPrice:C}");
            return pricingList.ToString();
        }
    }


}
