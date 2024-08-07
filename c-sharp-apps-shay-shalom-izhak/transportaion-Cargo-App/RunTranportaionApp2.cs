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

            // Initial loading at the first port
            Console.WriteLine("At Port 1:");
            bool loadResult1 = testShip.Load(testItem1);
            Console.WriteLine($"Load result 1: {loadResult1}"); // Expected: True
            DisplayLoadedItems(testShip, "after loading the first item at Port 1");

            bool loadResult2 = testShip.Load(testItem2);
            Console.WriteLine($"Load result 2: {loadResult2}"); // Expected: True
            DisplayLoadedItems(testShip, "after loading the second item at Port 1");

            // Travel to Port 2
            testShip.DistanceToNextPort = 1500;
            Console.WriteLine("Traveling to Port 2...");
            testShip.TravelToNextPort();

            // Operations at Port 2
            Console.WriteLine("At Port 2:");
            testShip.UnLoad(testItem1); // Unload the first item
            DisplayLoadedItems(testShip, "after unloading the first item at Port 2");

            // Load the first item back and another item
            testShip.Load(testItem1);
            DisplayLoadedItems(testShip, "after loading the first item back at Port 2");

            ElectricItem testItem3 = new ElectricItem(30, 60, 15, 8, true, 220, "NewBrand", "NewModel")
            {
                CargoType = CargoType.Ship
            };
            testShip.Load(testItem3);
            DisplayLoadedItems(testShip, "after loading a new item at Port 2");

            // Travel to Port 3
            testShip.DistanceToNextPort = 2500;
            Console.WriteLine("Traveling to Port 3...");
            testShip.TravelToNextPort();

            // Operations at Port 3
            Console.WriteLine("At Port 3:");
            testShip.UnLoad(testItem2); // Unload the second item
            DisplayLoadedItems(testShip, "after unloading the second item at Port 3");

            testShip.UnLoad(testItem3); // Unload the new item
            DisplayLoadedItems(testShip, "after unloading the new item at Port 3");

            // End of the journey, display final cargo status
            Console.WriteLine("Final cargo status:");
            DisplayLoadedItems(testShip, "at the end of the journey");

            Console.WriteLine("TestFunction executed successfully.");
        }

        private static void DisplayLoadedItems(Ship ship, string message)
        {
            Console.WriteLine($"Items loaded in the ship {message}:");
            foreach (var item in ship.ItemsToLoad)
            {
                Console.WriteLine($"- Item: {item.GetType().Name}, Volume: {item.GetVolume()} m³, Weight: {item.GetWeight()} kg");
            }
        }
    }
}