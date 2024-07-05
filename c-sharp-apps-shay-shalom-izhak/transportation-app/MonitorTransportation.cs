using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportation_app
{
    public class MonitorTransportation
    {
        public static void Test1()
        {
            Console.WriteLine("Starting Test1...");

            // Create instances of different transportation vehicles
            PublicVehicle[] vehicles = new PublicVehicle[]
            {
                new Bus(1, 101, 100, 50, 2),
                new PassengersTrain(2, 102, 250, new Crone(10, 5), 3),
                new PassengersAirplain(3, 103, 4, 50, 20, 6),
                new Bus(4, 104, 80, 40, 3),
            };

            // Test maximum speed for each vehicle
            Console.WriteLine("\nTesting maximum speeds:");
            foreach (PublicVehicle vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.GetType().Name} {vehicle.Line}-{vehicle.Id}: MaxSpeed = {vehicle.MaxSpeed}");
            }

            // Test uploading passengers for each vehicle
            Console.WriteLine("\nTesting uploading passengers:");

            foreach (PublicVehicle vehicle in vehicles)
            {
                int passengersToUpload = 30;
                int initialPassengers = vehicle.Passengers;

                Console.WriteLine($"{vehicle.GetType().Name} {vehicle.Line}-{vehicle.Id}: Initial Passengers = {initialPassengers}");

                // Upload passengers
                vehicle.UploadPassengers(passengersToUpload);

                // Display current passengers after upload
                int currentPassengers = vehicle.Passengers;
                Console.WriteLine($"After uploading {passengersToUpload} passengers: Current Passengers = {currentPassengers}");

                // Check if uploading succeeded based on vehicle capacity
                if (currentPassengers > initialPassengers)
                {
                    Console.WriteLine($"Upload successful for {vehicle.GetType().Name} {vehicle.Line}-{vehicle.Id}");
                }
                else
                {
                    Console.WriteLine($"Upload failed for {vehicle.GetType().Name} {vehicle.Line}-{vehicle.Id}");
                }
            }

            // Additional test cases can be added here as needed

            Console.WriteLine("Test1 completed.");
        }

        public static void MyTest()
        {
            Console.WriteLine("Starting MyTest...");

            // Create instances of different transportation vehicles
            PublicVehicle[] vehicles = new PublicVehicle[]
            {
                new Bus(1, 101, 100, 50, 2),
                new PassengersTrain(2, 102, 250, new Crone(10, 5), 3),
                new PassengersAirplain(3, 103, 4, 50, 20, 6),
                new Bus(4, 104, 80, 40, 3),
                new PassengersTrain(5, 105, 200, new Crone(8, 4), 2)
            };

            // Execute UploadPassengers method on each vehicle
            foreach (PublicVehicle vehicle in vehicles)
            {
                Console.WriteLine($"\n{vehicle.GetType().Name} {vehicle.Line}-{vehicle.Id}:");
                vehicle.UploadPassengers(10);
                vehicle.UploadPassengers(20);
                vehicle.UploadPassengers(5);
                Console.WriteLine($"Current passengers: {vehicle.Passengers}");
            }

            Console.WriteLine("MyTest completed.");
        }

        public static int CountPlains(PublicVehicle[] vehicles)
        {
            int count = 0;
            foreach (PublicVehicle vehicle in vehicles)
            {
                if (vehicle is PassengersAirplain)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

