using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportaion_Cargo_App
{
    public abstract class CargoVehicle : IContainable
    {
        private static Random random = new Random();

        public Driver Driver { get; set; }
        public decimal MaxWeight { get; set; }
        public decimal MaxVolume { get; set; }
        public bool IsReadyToDrive { get; set; }
        public bool IsOverloaded { get; set; }
        public Port NextPort { get; set; }
        public Port CurrentPort { get; set; }
        public int CurrentTripID { get; set; }
        public List<IPortable> ItemsToLoad { get; set; }
        public Dictionary<int, decimal> ExpectedTripCost { get; set; }
        public IShippingPriceCalculator PriceCalculator { get; set; }
        public int DistanceToNextPort { get; set; }

        public CargoVehicle()
        {
            ItemsToLoad = new List<IPortable>();
            ExpectedTripCost = new Dictionary<int, decimal>();
            CurrentTripID = GenerateRandomTripID();
        }

        private int GenerateRandomTripID()
        {
            return random.Next(1000, 10000);
        }

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
        public abstract string GetPricingList();

        public void ApproveTrip()
        {
            if (ItemsToLoad.TrueForAll(item => item.IsLoaded()) && Driver != null)
            {
                IsReadyToDrive = true;
                ExpectedTripCost[CurrentTripID] = CalculateTotalPrice();
            }
        }

        public void TravelToNextPort()
        {
            if (IsReadyToDrive && NextPort != null)
            {
                CurrentPort = NextPort;
                NextPort = null;
            }
        }

        private decimal CalculateTotalPrice()
        {
            return PriceCalculator.CalculatePrice(ItemsToLoad, DistanceToNextPort);
        }
    }
}
