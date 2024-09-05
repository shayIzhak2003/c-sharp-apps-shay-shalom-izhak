using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportaion_Cargo_App
{
    public abstract class StorageStructure : IContainable
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public List<IPortable> StoredItems { get; set; } = new List<IPortable>();

        public abstract bool Load(IPortable item);
        public abstract bool Load(List<IPortable> items);
        public abstract bool UnLoad();
        public abstract bool UnLoad(IPortable item);
        public abstract bool UnLoad(List<IPortable> items);
        public abstract bool IsHaveRoom();
        public abstract bool IsOverload();
        public abstract decimal GetMaxVolume();
        public abstract decimal GetMaxWeight();
        public abstract decimal GetCurrentVolume();
        public abstract decimal GetCurrentWeight();

        public StorageStructure()
        {
            StoredItems = new List<IPortable>();
        }
    }
}
