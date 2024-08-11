using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportaion_Cargo_App
{
    public class RunTranportaionApp2
    {
        public static void TestFunction()
        {
            // Create a Train instance with Cron as the limiter
            Train testTrain = new Train(maxVolume: 100000m, maxWeight: 200000m);

            // Create a Ship instance with Container as the limiter
            Ship testShip = new Ship(maxItems: 5, maxVolume: 150000m, maxWeight: 300000m);

            // Create test items
            ElectricItem testItem1 = new ElectricItem(10, 22, 4, 2, false, 110, "TestBrand1", "TestModel1");
            ElectricItem testItem2 = new ElectricItem(10, 22, 4, 2, false, 110, "TestBrand2", "TestModel2");
            ElectricItem testItem3 = new ElectricItem(30, 60, 15, 8, true, 220, "NewBrand", "NewModel");
            ElectricItem testItem4 = new ElectricItem(50, 80, 20, 10, true, 240, "BrandX", "ModelX");
            ElectricItem testItem5 = new ElectricItem(60, 100, 25, 12, true, 260, "BrandY", "ModelY");
            ElectricItem testItem6 = new ElectricItem(70, 120, 30, 14, true, 280, "BrandZ", "ModelZ"); // This will exceed the maxItems limit on the Ship

            // Create a ShippingPriceCalculator instance
            ShippingPriceCalculator priceCalculator = new ShippingPriceCalculator();

            // Initial loading at the first port
            Console.WriteLine("At Port 1:");

            // Load items onto the train
            bool loadResult1 = testTrain.Load(testItem1);
            Console.WriteLine($"Train Load result 1: {loadResult1}"); // Expected: True
            DisplayLoadedItems(testTrain, "after loading the first item onto the Train at Port 1");

            bool loadResult2 = testTrain.Load(testItem2);
            Console.WriteLine($"Train Load result 2: {loadResult2}"); // Expected: True
            DisplayLoadedItems(testTrain, "after loading the second item onto the Train at Port 1");

            // Load items onto the ship
            bool shipLoadResult1 = testShip.Load(testItem1);
            Console.WriteLine($"Ship Load result 1: {shipLoadResult1}"); // Expected: True
            DisplayLoadedItems(testShip, "after loading the first item onto the Ship at Port 1");

            bool shipLoadResult2 = testShip.Load(testItem2);
            Console.WriteLine($"Ship Load result 2: {shipLoadResult2}"); // Expected: True
            DisplayLoadedItems(testShip, "after loading the second item onto the Ship at Port 1");

            // Attempt to load more items to reach the maximum items limit on the ship
            Console.WriteLine("Attempting to load additional items onto the Ship:");

            bool shipLoadResult3 = testShip.Load(testItem3);
            DisplayLoadResult(shipLoadResult3, "Ship", "Item 3");

            bool shipLoadResult4 = testShip.Load(testItem4);
            DisplayLoadResult(shipLoadResult4, "Ship", "Item 4");

            bool shipLoadResult5 = testShip.Load(testItem5);
            DisplayLoadResult(shipLoadResult5, "Ship", "Item 5");

            // This should fail as it exceeds the maxItems limit
            bool shipLoadResult6 = testShip.Load(testItem6);
            DisplayLoadResult(shipLoadResult6, "Ship", "Item 6");

            // Travel to Port 2
            testTrain.DistanceToNextPort = 1500;
            Console.WriteLine("Train traveling to Port 2...");
            testTrain.TravelToNextPort();

            testShip.DistanceToNextPort = 2000;
            Console.WriteLine("Ship traveling to Port 2...");
            testShip.TravelToNextPort();

            // Calculate and display the price after traveling to Port 2
            decimal trainPriceToPort2 = priceCalculator.CalculatePrice(testTrain.ItemsToLoad, testTrain.DistanceToNextPort);
            decimal shipPriceToPort2 = priceCalculator.CalculatePrice(testShip.ItemsToLoad, testShip.DistanceToNextPort);
            Console.WriteLine($"Price for Train journey to Port 2: {trainPriceToPort2:C}");
            Console.WriteLine($"Price for Ship journey to Port 2: {shipPriceToPort2:C}");

            // Operations at Port 2
            Console.WriteLine("At Port 2:");

            // Train operations at Port 2
            testTrain.UnLoad(testItem1); // Unload the first item from the train
            DisplayLoadedItems(testTrain, "after unloading the first item from the Train at Port 2");

            testTrain.Load(testItem1); // Load the first item back onto the train
            DisplayLoadedItems(testTrain, "after loading the first item back onto the Train at Port 2");

            testTrain.Load(testItem3); // Load a new item onto the train
            DisplayLoadedItems(testTrain, "after loading a new item onto the Train at Port 2");

            // Ship operations at Port 2
            testShip.UnLoad(testItem1); // Unload the first item from the ship
            DisplayLoadedItems(testShip, "after unloading the first item from the Ship at Port 2");

            testShip.Load(testItem1); // Load the first item back onto the ship
            DisplayLoadedItems(testShip, "after loading the first item back onto the Ship at Port 2");

            // Travel to Port 3
            testTrain.DistanceToNextPort = 2500;
            Console.WriteLine("Train traveling to Port 3...");
            testTrain.TravelToNextPort();

            testShip.DistanceToNextPort = 3000;
            Console.WriteLine("Ship traveling to Port 3...");
            testShip.TravelToNextPort();

            // Calculate and display the price after traveling to Port 3
            decimal trainPriceToPort3 = priceCalculator.CalculatePrice(testTrain.ItemsToLoad, testTrain.DistanceToNextPort);
            decimal shipPriceToPort3 = priceCalculator.CalculatePrice(testShip.ItemsToLoad, testShip.DistanceToNextPort);
            Console.WriteLine($"Price for Train journey to Port 3: {trainPriceToPort3:C}");
            Console.WriteLine($"Price for Ship journey to Port 3: {shipPriceToPort3:C}");

            // Operations at Port 3
            Console.WriteLine("At Port 3:");

            // Train operations at Port 3
            testTrain.UnLoad(testItem2); // Unload the second item from the train
            DisplayLoadedItems(testTrain, "after unloading the second item from the Train at Port 3");

            testTrain.UnLoad(testItem3); // Unload the new item from the train
            DisplayLoadedItems(testTrain, "after unloading the new item from the Train at Port 3");

            // Ship operations at Port 3
            testShip.UnLoad(testItem2); // Unload the second item from the ship
            DisplayLoadedItems(testShip, "after unloading the second item from the Ship at Port 3");

            // End of the journey, display final cargo status for both train and ship
            Console.WriteLine("Final cargo status:");
            DisplayLoadedItems(testTrain, "on the Train at the end of the journey");
            DisplayLoadedItems(testShip, "on the Ship at the end of the journey");

            // Calculate and display the total price for the entire journey
            decimal totalTrainPrice = trainPriceToPort2 + trainPriceToPort3;
            decimal totalShipPrice = shipPriceToPort2 + shipPriceToPort3;
            Console.WriteLine($"Total price for Train journey: {totalTrainPrice:C}");
            Console.WriteLine($"Total price for Ship journey: {totalShipPrice:C}");

            Console.WriteLine("TestFunction executed successfully.");
        }

        private static void DisplayLoadedItems(CargoVehicle vehicle, string message)
        {
            Console.WriteLine($"Items loaded in the {vehicle.GetType().Name} {message}:");
            foreach (var item in vehicle.ItemsToLoad)
            {
                Console.WriteLine($"- Item: {item.GetType().Name}, Volume: {item.GetVolume()} m³, Weight: {item.GetWeight()} kg");
            }
        }

        private static void DisplayLoadResult(bool result, string vehicleName, string itemName)
        {
            if (result)
            {
                Console.WriteLine($"{vehicleName} successfully loaded {itemName}.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{vehicleName} failed to load {itemName}. Maximum capacity reached!");
                Console.ResetColor();
            }
        }
    }

}