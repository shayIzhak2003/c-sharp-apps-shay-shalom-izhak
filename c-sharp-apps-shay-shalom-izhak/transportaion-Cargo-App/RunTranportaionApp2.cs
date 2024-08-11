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

            // Create test items
            ElectricItem testItem1 = new ElectricItem(10, 22, 4, 2, false, 110, "TestBrand1", "TestModel1");
            ElectricItem testItem2 = new ElectricItem(10, 22, 4, 2, false, 110, "TestBrand2", "TestModel2");

            // Initial loading at the first port
            Console.WriteLine("At Port 1:");
            bool loadResult1 = testTrain.Load(testItem1);
            Console.WriteLine($"Load result 1: {loadResult1}"); // Expected: True
            DisplayLoadedItems(testTrain, "after loading the first item at Port 1");

            bool loadResult2 = testTrain.Load(testItem2);
            Console.WriteLine($"Load result 2: {loadResult2}"); // Expected: True
            DisplayLoadedItems(testTrain, "after loading the second item at Port 1");

            // Travel to Port 2
            testTrain.DistanceToNextPort = 1500;
            Console.WriteLine("Traveling to Port 2...");
            testTrain.TravelToNextPort();

            // Operations at Port 2
            Console.WriteLine("At Port 2:");
            testTrain.UnLoad(testItem1); // Unload the first item
            DisplayLoadedItems(testTrain, "after unloading the first item at Port 2");

            // Load the first item back and another item
            testTrain.Load(testItem1);
            DisplayLoadedItems(testTrain, "after loading the first item back at Port 2");

            ElectricItem testItem3 = new ElectricItem(30, 60, 15, 8, true, 220, "NewBrand", "NewModel");
            testTrain.Load(testItem3);
            DisplayLoadedItems(testTrain, "after loading a new item at Port 2");

            // Travel to Port 3
            testTrain.DistanceToNextPort = 2500;
            Console.WriteLine("Traveling to Port 3...");
            testTrain.TravelToNextPort();

            // Operations at Port 3
            Console.WriteLine("At Port 3:");
            testTrain.UnLoad(testItem2); // Unload the second item
            DisplayLoadedItems(testTrain, "after unloading the second item at Port 3");

            testTrain.UnLoad(testItem3); // Unload the new item
            DisplayLoadedItems(testTrain, "after unloading the new item at Port 3");

            // End of the journey, display final cargo status
            Console.WriteLine("Final cargo status:");
            DisplayLoadedItems(testTrain, "at the end of the journey");

            Console.WriteLine("TestFunction executed successfully.");
        }

        private static void DisplayLoadedItems(Train train, string message)
        {
            Console.WriteLine($"Items loaded in the train {message}:");
            foreach (var item in train.ItemsToLoad)
            {
                Console.WriteLine($"- Item: {item.GetType().Name}, Volume: {item.GetVolume()} m³, Weight: {item.GetWeight()} kg");
            }
        }
    }


}