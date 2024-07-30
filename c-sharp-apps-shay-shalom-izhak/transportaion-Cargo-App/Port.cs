using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportaion_Cargo_App
{
    public class Port : StorageStructure
    {
        public decimal MaxWeight { get; set; }
        public decimal MaxVolume { get; set; }

        public Port(decimal maxWeight, decimal maxVolume)
        {
            MaxWeight = maxWeight;
            MaxVolume = maxVolume;
        }

        public override bool Load(IPortable item)
        {
            if (IsHaveRoom() && !IsOverload())
            {
                StoredItems.Add(item);
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
            if (StoredItems.Count > 0)
            {
                StoredItems.Clear();
                return true;
            }
            return false;
        }

        public override bool UnLoad(IPortable item)
        {
            if (StoredItems.Contains(item))
            {
                StoredItems.Remove(item);
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
            return StoredItems.Sum(item => item.GetVolume());
        }

        public override decimal GetCurrentWeight()
        {
            return StoredItems.Sum(item => item.GetWeight());
        }
    }

}
