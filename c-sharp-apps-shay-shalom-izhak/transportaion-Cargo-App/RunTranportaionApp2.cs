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

            // Create a Plane instance with Container as the limiter
            Plane testPlane = new Plane(maxItems: 5, maxVolume: 80000m, maxWeight: 100000m);

            // Create test items
            ElectricItem testItem1 = new ElectricItem(10, 22, 4, 2, false, 110, "TestBrand1", "TestModel1");
            ElectricItem testItem2 = new ElectricItem(10, 22, 4, 2, false, 110, "TestBrand2", "TestModel2");
            ElectricItem testItem3 = new ElectricItem(30, 60, 15, 8, true, 220, "NewBrand", "NewModel");
            ElectricItem testItem4 = new ElectricItem(50, 80, 20, 10, true, 240, "BrandX", "ModelX");
            ElectricItem testItem5 = new ElectricItem(60, 100, 25, 12, true, 260, "BrandY", "ModelY");
            ElectricItem testItem6 = new ElectricItem(70, 120, 30, 14, true, 280, "BrandZ", "ModelZ"); // This will exceed the maxItems limit on the Ship
            Furniture chairItem = new Chair(2, 2, 4, 12, false, "wood", "red", true, false); // Adding the Chair item
            Furniture tableItem = new Table(4, 4, 6, 34, true, "iron", "black", 4, true); // Adding the Table item
            Furniture sofaItem = new Sofa(3, 3, 7, 34, false, "wood & iron", "brige", 6, true); // Adding the Sofa item

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

            // Load items onto the plane
            bool planeLoadResult1 = testPlane.Load(testItem1);
            Console.WriteLine($"Plane Load result 1: {planeLoadResult1}"); // Expected: True
            DisplayLoadedItems(testPlane, "after loading the first item onto the Plane at Port 1");

            bool planeLoadResult2 = testPlane.Load(testItem2);
            Console.WriteLine($"Plane Load result 2: {planeLoadResult2}"); // Expected: True
            DisplayLoadedItems(testPlane, "after loading the second item onto the Plane at Port 1");

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

            // Load the chair onto the train
            bool trainLoadResult3 = testTrain.Load(chairItem);
            DisplayLoadResult(trainLoadResult3, "Train", "Chair Item");

            // Load additional items onto the plane to test its limits
            Console.WriteLine("Attempting to load additional items onto the Plane:");

            bool planeLoadResult3 = testPlane.Load(testItem3);
            DisplayLoadResult(planeLoadResult3, "Plane", "Item 3");

            bool planeLoadResult4 = testPlane.Load(testItem4);
            DisplayLoadResult(planeLoadResult4, "Plane", "Item 4");

            bool planeLoadResult5 = testPlane.Load(testItem5);
            DisplayLoadResult(planeLoadResult5, "Plane", "Item 5");

            // Load the table onto the train
            bool trainLoadResult4 = testTrain.Load(tableItem);
            DisplayLoadResult(trainLoadResult4, "Train", "Table Item");

            // Load the sofa onto the train
            bool trainLoadResult5 = testTrain.Load(sofaItem);
            DisplayLoadResult(trainLoadResult5, "Train", "Sofa Item");

            // Travel to Port 2
            testTrain.DistanceToNextPort = 1500;
            Console.WriteLine("Train traveling to Port 2...");
            testTrain.TravelToNextPort();

            testShip.DistanceToNextPort = 2000;
            Console.WriteLine("Ship traveling to Port 2...");
            testShip.TravelToNextPort();

            testPlane.DistanceToNextPort = 1000;
            Console.WriteLine("Plane traveling to Port 2...");
            testPlane.TravelToNextPort();

            // Calculate and display the price after traveling to Port 2
            decimal trainPriceToPort2 = priceCalculator.CalculatePrice(testTrain.ItemsToLoad, testTrain.DistanceToNextPort);
            decimal shipPriceToPort2 = priceCalculator.CalculatePrice(testShip.ItemsToLoad, testShip.DistanceToNextPort);
            decimal planePriceToPort2 = priceCalculator.CalculatePrice(testPlane.ItemsToLoad, testPlane.DistanceToNextPort);
            Console.WriteLine($"Price for Train journey to Port 2: ${trainPriceToPort2:N2}");
            Console.WriteLine($"Price for Ship journey to Port 2: ${shipPriceToPort2:N2}");
            Console.WriteLine($"Price for Plane journey to Port 2: ${planePriceToPort2:N2}");

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

            // Plane operations at Port 2
            testPlane.UnLoad(testItem1); // Unload the first item from the plane
            DisplayLoadedItems(testPlane, "after unloading the first item from the Plane at Port 2");

            testPlane.Load(testItem1); // Load the first item back onto the plane
            DisplayLoadedItems(testPlane, "after loading the first item back onto the Plane at Port 2");

            // Travel to Port 3
            testTrain.DistanceToNextPort = 2500;
            Console.WriteLine("Train traveling to Port 3...");
            testTrain.TravelToNextPort();

            testShip.DistanceToNextPort = 3000;
            Console.WriteLine("Ship traveling to Port 3...");
            testShip.TravelToNextPort();

            testPlane.DistanceToNextPort = 2000;
            Console.WriteLine("Plane traveling to Port 3...");
            testPlane.TravelToNextPort();

            // Calculate and display the price after traveling to Port 3
            decimal trainPriceToPort3 = priceCalculator.CalculatePrice(testTrain.ItemsToLoad, testTrain.DistanceToNextPort);
            decimal shipPriceToPort3 = priceCalculator.CalculatePrice(testShip.ItemsToLoad, testShip.DistanceToNextPort);
            decimal planePriceToPort3 = priceCalculator.CalculatePrice(testPlane.ItemsToLoad, testPlane.DistanceToNextPort);
            Console.WriteLine($"Price for Train journey to Port 3: ${trainPriceToPort3:N2}");
            Console.WriteLine($"Price for Ship journey to Port 3: ${shipPriceToPort3:N2}");
            Console.WriteLine($"Price for Plane journey to Port 3: ${planePriceToPort3:N2}");

            // Operations at Port 3
            Console.WriteLine("At Port 3:");

            // Train operations at Port 3
            testTrain.UnLoad(testItem1); // Unload the first item from the train
            DisplayLoadedItems(testTrain, "after unloading the first item from the Train at Port 3");

            testTrain.Load(testItem2); // Load the second item onto the train
            DisplayLoadedItems(testTrain, "after loading the second item onto the Train at Port 3");

            testTrain.Load(tableItem); // Load the table item onto the train
            DisplayLoadedItems(testTrain, "after loading the table item onto the Train at Port 3");

            // Ship operations at Port 3
            testShip.UnLoad(testItem1); // Unload the first item from the ship
            DisplayLoadedItems(testShip, "after unloading the first item from the Ship at Port 3");

            testShip.Load(testItem2); // Load the second item onto the ship
            DisplayLoadedItems(testShip, "after loading the second item onto the Ship at Port 3");

            // Plane operations at Port 3
            testPlane.UnLoad(testItem1); // Unload the first item from the plane
            DisplayLoadedItems(testPlane, "after unloading the first item from the Plane at Port 3");

            testPlane.Load(testItem2); // Load the second item onto the plane
            DisplayLoadedItems(testPlane, "after loading the second item onto the Plane at Port 3");

            // Test removal of the table item from the train
            bool trainRemoveResult1 = testTrain.UnLoad(tableItem);
            Console.WriteLine($"Train Remove result for Table Item: {trainRemoveResult1}"); // Expected: True
            DisplayLoadedItems(testTrain, "after removing the table item from the Train at Port 3");

            // Test removal of the sofa item from the train
            bool trainRemoveResult2 = testTrain.UnLoad(sofaItem);
            Console.WriteLine($"Train Remove result for Sofa Item: {trainRemoveResult2}"); // Expected: True
            DisplayLoadedItems(testTrain, "after removing the sofa item from the Train at Port 3");
        }

        private static void DisplayLoadedItems(CargoVehicle vehicle, string message)
        {
            Console.WriteLine($"Items loaded in the {vehicle.GetType().Name} {message}:");

            foreach (var item in vehicle.ItemsToLoad)
            {
                string itemName = item.GetType().Name;
                decimal volume = item.GetVolume();
                decimal weight = item.GetWeight();

                if (item is Chair chair)
                {
                    decimal width = chair.Width;
                    decimal length = chair.Length;
                    decimal height = chair.Height;
                    bool fragile = chair.Fragile;
                    string material = chair.Material;
                    string color = chair.Color;
                    bool hasArmrests = chair.HasArmrests;
                    bool isAdjustable = chair.IsAdjustable;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"- Item: {itemName}, Volume: {volume} m³, Weight: {weight} kg, " +
                                      $"Width: {width} m, Length: {length} m, Height: {height} m, Fragile: {fragile}, " +
                                      $"Material: {material}, Color: {color}, Has Armrests: {hasArmrests}, Is Adjustable: {isAdjustable}");
                    Console.ResetColor();

                }
                else if (item is Table table)
                {
                    decimal width = table.Width;
                    decimal length = table.Length;
                    decimal height = table.Height;
                    bool fragile = table.Fragile;
                    string material = table.Material;
                    string color = table.Color;
                    int numberOfLegs = table.NumberOfLegs;
                    bool isExtendable = table.IsExtendable;

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"- Item: {itemName}, Volume: {volume} m³, Weight: {weight} kg, " +
                                      $"Width: {width} m, Length: {length} m, Height: {height} m, Fragile: {fragile}, " +
                                      $"Material: {material}, Color: {color}, Number of Legs: {numberOfLegs}, Is Extendable: {isExtendable}");
                    Console.ResetColor();
                }
                else if (item is Sofa sofa)
                {
                    decimal width = sofa.Width;
                    decimal length = sofa.Length;
                    decimal height = sofa.Height;
                    bool fragile = sofa.Fragile;
                    string material = sofa.Material;
                    string color = sofa.Color;
                    int seatingCapacity = sofa.SeatingCapacity;
                    bool hasStorage = sofa.HasStorage;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"- Item: {itemName}, Volume: {volume} m³, Weight: {weight} kg, " +
                                      $"Width: {width} m, Length: {length} m, Height: {height} m, Fragile: {fragile}, " +
                                      $"Material: {material}, Color: {color}, Seating Capacity: {seatingCapacity}, Has Storage: {hasStorage}");
                    Console.ResetColor();
                }

                else
                {
                    Console.WriteLine($"- Item: {itemName}, Volume: {volume} m³, Weight: {weight} kg");
                }
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