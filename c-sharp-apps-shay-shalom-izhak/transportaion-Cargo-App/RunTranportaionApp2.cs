//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace c_sharp_apps_shay_shalom_izhak.transportaion_Cargo_App
//{
//    public class RunTranportaionApp2
//    {
//        public static void DemoMain()
//        {
//            // Example usage
//            Driver driver = new Driver
//            {
//                FirstName = "John",
//                LastName = "Doe",
//                ID = 12345,
//                CargoType = CargoType.Truck
//            };

//            Ship ship = new Ship
//            {
//                Driver = driver,
//                MaxWeight = 100000m,
//                MaxVolume = 500000m,
//                PriceCalculator = new ShippingPriceCalculator(),
//                DistanceToNextPort = 1000,
//                NextPort = "Port B",
//                CurrentPort = "Port A"
//            };

//            ElectricItem item = new ElectricItem
//            {
//                Width = 50,
//                Length = 100,
//                Height = 20,
//                Weight = 10,
//                Fragile = true,
//                PowerConsumption = 200,
//                Brand = "BrandX",
//                Model = "ModelY"
//            };

//            ship.Load(item);
//            driver.Approve(ship);
//            ship.TravelToNextPort();
//        }
//    }
//}
