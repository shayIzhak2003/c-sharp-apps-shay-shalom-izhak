using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportaion_Cargo_App
{
    public class Ship : CargoVehicle
    {
        public override bool Load(IPortable item)
        {
            if (IsHaveRoom() && !IsOverload())
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
                ItemsToLoad.Clear();
                return true;
            }
            return false;
        }

        public override bool UnLoad(IPortable item)
        {
            if (ItemsToLoad.Contains(item))
            {
                ItemsToLoad.Remove(item);
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
            return GetCurrentVolume() < GetMaxVolume() && GetCurrentWeight() < GetMaxWeight();
        }

        public override bool IsOverload()
        {
            return GetCurrentVolume() > GetMaxVolume() || GetCurrentWeight() > GetMaxWeight();
        }

        public override decimal GetMaxVolume()
        {
            return MaxVolume;
        }

        public override decimal GetMaxWeight()
        {
            return MaxWeight;
        }

        public override decimal GetCurrentVolume()
        {
            return ItemsToLoad.Sum(item => item.GetVolume());
        }

        public override decimal GetCurrentWeight()
        {
            return ItemsToLoad.Sum(item => item.GetWeight());
        }

        public override string GetPricingList()
        {
            return "Pricing list for ship transportation";
        }
    }

}
