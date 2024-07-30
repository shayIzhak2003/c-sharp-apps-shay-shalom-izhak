using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportaion_Cargo_App
{
    public interface IPortable
    {
        decimal GetArea();
        int[] GetSize();
        decimal GetVolume();
        decimal GetWeight();
        void PackageItem();
        bool IsPackaged();
        void UnPackage();
        bool IsFragile();
        StorageStructure GetLocation();
        bool IsLoaded();
    }

}
