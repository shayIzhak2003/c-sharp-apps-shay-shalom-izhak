using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportaion_Cargo_App
{
    public class RunTranportaionApp2
    {
        public static void DemoMain()
        {
            // Example usage
            Driver driver = new Driver
            {
                FirstName = "John",
                LastName = "Doe",
                ID = 12345,
                CargoType = CargoType.Truck
            };

            Ship ship = new Ship
            {
                Driver = driver,
                MaxWeight = 100000m,
                MaxVolume = 500000m,
                PriceCalculator = new ShippingPriceCalculator(),
                DistanceToNextPort = 1000
            };

            ElectricItem item = new ElectricItem(50, 100, 20, 10, true, 220, "BrandName", "ModelName");

            ship.Load(item);
            driver.Approve(ship);
            ship.TravelToNextPort();
        }

        public static void TestFunction()
        {
            // Create instances
            Driver testDriver = new Driver
            {
                FirstName = "Jane",
                LastName = "Smith",
                ID = 54321,
                CargoType = CargoType.Ship
            };

            Ship testShip = new Ship
            {
                Driver = testDriver,
                MaxWeight = 200000m,
                MaxVolume = 1000000m,
                PriceCalculator = new ShippingPriceCalculator(),
                DistanceToNextPort = 2000
            };

            ElectricItem testItem1 = new ElectricItem(100, 200, 40, 20, false, 110, "TestBrand1", "TestModel1")
            {
                CargoType = CargoType.Ship
            };
            ElectricItem testItem2 = new ElectricItem(50, 100, 20, 10, true, 220, "TestBrand2", "TestModel2")
            {
                CargoType = CargoType.Ship
            };

            // Load items
            bool loadResult1 = testShip.Load(testItem1);
            bool loadResult2 = testShip.Load(testItem2);
           

            // Check if items are loaded
            Console.WriteLine($"Load result 1: {loadResult1}"); // Expected: True
            Console.WriteLine($"Load result 2: {loadResult2}"); // Expected: True

            // Calculate shipping price for ship
            decimal shipPrice1 = testShip.PriceCalculator.CalculatePrice(testItem1, testShip.DistanceToNextPort);
            decimal shipPrice2 = testShip.PriceCalculator.CalculatePrice(testItem2, testShip.DistanceToNextPort);

            Console.WriteLine($"Shipping price for item 1 by ship: {shipPrice1}");
            Console.WriteLine($"Shipping price for item 2 by ship: {shipPrice2}");

            // Check Plane Cargo
            testItem1.CargoType = CargoType.Plane;
            testItem2.CargoType = CargoType.Plane;
            decimal planePrice1 = testShip.PriceCalculator.CalculatePrice(testItem1, testShip.DistanceToNextPort);
            decimal planePrice2 = testShip.PriceCalculator.CalculatePrice(testItem2, testShip.DistanceToNextPort);
            Console.WriteLine($"Shipping price for item 1 by plane: {planePrice1}");
            Console.WriteLine($"Shipping price for item 2 by plane: {planePrice2}");

            // Check Train Cargo
            testItem1.CargoType = CargoType.Train;
            testItem2.CargoType = CargoType.Train;
            decimal trainPrice1 = testShip.PriceCalculator.CalculatePrice(testItem1, testShip.DistanceToNextPort);
            decimal trainPrice2 = testShip.PriceCalculator.CalculatePrice(testItem2, testShip.DistanceToNextPort);
            Console.WriteLine($"Shipping price for item 1 by train: {trainPrice1}");
            Console.WriteLine($"Shipping price for item 2 by train: {trainPrice2}");

            // Check generic storage
            //testItem1.CargoType = CargoType.Storage;
            //testItem2.CargoType = CargoType.Storage;
            //decimal storagePrice1 = testShip.PriceCalculator.CalculatePrice(testItem1, testShip.DistanceToNextPort);
            //decimal storagePrice2 = testShip.PriceCalculator.CalculatePrice(testItem2, testShip.DistanceToNextPort);
            //Console.WriteLine($"Shipping price for item 1 by storage: {storagePrice1}");
            //Console.WriteLine($"Shipping price for item 2 by storage: {storagePrice2}");

            // Unload items
            bool unloadResult1 = testShip.UnLoad(testItem1);
            bool unloadResult2 = testShip.UnLoad(testItem2);

            // Check if items are unloaded
            Console.WriteLine($"Unload result 1: {unloadResult1}"); // Expected: True
            Console.WriteLine($"Unload result 2: {unloadResult2}"); // Expected: True

            Console.WriteLine("TestFunction executed successfully.");
        }

    }
}