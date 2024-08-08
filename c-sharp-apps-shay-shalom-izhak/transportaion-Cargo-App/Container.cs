using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportaion_Cargo_App
{
    public class Container
    {
        public int MaxItems { get; private set; }
        private List<IPortable> items;

        public Container(int maxItems)
        {
            MaxItems = maxItems;
            items = new List<IPortable>();
        }

        public bool AddItem(IPortable item)
        {
            if (items.Count < MaxItems)
            {
                items.Add(item);
                return true;
            }
            return false;
        }

        public bool RemoveItem(IPortable item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
                return true;
            }
            return false;
        }

        public List<IPortable> GetItems()
        {
            return items;
        }

        public int GetCurrentItemCount()
        {
            return items.Count;
        }
    }
}
