using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportaion_Cargo_App
{
    public interface IContainable
    {
        bool Load(IPortable item);
        bool Load(List<IPortable> items);
        bool UnLoad();
        bool UnLoad(IPortable item);
        bool UnLoad(List<IPortable> items);
        bool IsHaveRoom();
        bool IsOverload();
        decimal GetMaxVolume();
        decimal GetMaxWeight();
        decimal GetCurrentVolume();
        decimal GetCurrentWeight();
    }
}
