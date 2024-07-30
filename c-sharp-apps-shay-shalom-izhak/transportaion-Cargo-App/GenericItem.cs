using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportaion_Cargo_App
{
    public class GenericItem : IPortable
    {
        public decimal Width { get; set; }
        public decimal Length { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public bool Packaged { get; set; }
        public bool Fragile { get; set; }
        public StorageStructure CurrentLocation { get; set; }
        public bool Loaded { get; set; }

        public decimal GetArea()
        {
            return Width * Length;
        }

        public int[] GetSize()
        {
            return new int[] { (int)Width, (int)Length, (int)Height };
        }

        public decimal GetVolume()
        {
            return Width * Length * Height;
        }

        public virtual decimal GetWeight()
        {
            return Weight;
        }

        public void PackageItem()
        {
            Packaged = true;
        }

        public bool IsPackaged()
        {
            return Packaged;
        }

        public void UnPackage()
        {
            Packaged = false;
        }

        public bool IsFragile()
        {
            return Fragile;
        }

        public StorageStructure GetLocation()
        {
            return CurrentLocation;
        }

        public bool IsLoaded()
        {
            return Loaded;
        }
    }
}
