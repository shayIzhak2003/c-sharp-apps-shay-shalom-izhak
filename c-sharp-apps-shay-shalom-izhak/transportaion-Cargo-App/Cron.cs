using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportaion_Cargo_App
{
    public class Cron
    {
        public decimal MaxVolume { get; private set; }
        public decimal MaxWeight { get; private set; }
        private List<IPortable> storedItems;

        public Cron(decimal maxVolume, decimal maxWeight)
        {
            MaxVolume = maxVolume;
            MaxWeight = maxWeight;
            storedItems = new List<IPortable>();
        }

        public bool AddItem(IPortable item)
        {
            if (GetCurrentVolume() + item.GetVolume() <= MaxVolume && GetCurrentWeight() + item.GetWeight() <= MaxWeight)
            {
                storedItems.Add(item);
                return true;
            }
            return false;
        }

        public bool RemoveItem(IPortable item)
        {
            if (storedItems.Contains(item))
            {
                storedItems.Remove(item);
                return true;
            }
            return false;
        }

        public decimal GetCurrentVolume()
        {
            return storedItems.Sum(item => item.GetVolume());
        }

        public decimal GetCurrentWeight()
        {
            return storedItems.Sum(item => item.GetWeight());
        }

        public bool IsOverloaded()
        {
            return GetCurrentVolume() > MaxVolume || GetCurrentWeight() > MaxWeight;
        }

        public string GetStatus()
        {
            return $"Current Volume: {GetCurrentVolume()} m³, Current Weight: {GetCurrentWeight()} kg, Max Volume: {MaxVolume} m³, Max Weight: {MaxWeight} kg";
        }

        // New method to get the current items
        public List<IPortable> GetCurrentItems()
        {
            return new List<IPortable>(storedItems);
        }
    }
}
