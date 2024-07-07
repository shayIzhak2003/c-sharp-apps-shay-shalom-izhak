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
            bool allPassed = true;

            // Test cases
            PublicVehicle p1 = new PublicVehicle(18, 8099065, 0, 80);
            Bus bus = new Bus(1, 2033355, 110, 50, 3);
            PassengersAirplain passengersAirplain1 = new PassengersAirplain(605, 987653, 4, 10, 60, 6);

            Crone crone1 = new Crone(20, 5);
            PassengersTrain passengersTrain1 = new PassengersTrain(65, 9998774, 250, crone1, 5);

            // Test 1: Check initial max speed for p1
            if (p1.MaxSpeed != 0)
            {
                Console.WriteLine($"Test 1 Error - Max Speed should be 0 but actual is {p1.MaxSpeed}");
                allPassed = false;
            }
            else
            {
                Console.WriteLine("Test 1 Passed");
            }

            // Test 2: Check initial max speed for bus
            if (bus.MaxSpeed != 110)
            {
                Console.WriteLine($"Test 2 Error - Max Speed should be 110 but actual is {bus.MaxSpeed}");
                allPassed = false;
            }
            else
            {
                Console.WriteLine("Test 2 Passed");
            }

            // Test 3: Attempt to set invalid max speed for bus
            bus.MaxSpeed = 110;
            if (bus.MaxSpeed != 110)
            {
                Console.WriteLine($"Test 3 Error - Max Speed should still be 110 but actual is {bus.MaxSpeed}");
                allPassed = false;
            }
            else
            {
                Console.WriteLine("Test 3 Passed");
            }
           
            // Test 4: Upload passengers for passengersAirplain1
            passengersAirplain1.UploadPassengers(400);
            if (passengersAirplain1.Passengers == 353 && passengersAirplain1.RejectedPassengers == 47)
            {
                Console.WriteLine("Test 4 Passed");
            }
            else
            {
                Console.WriteLine($"Test 4 Error - Current Passengers should be 353 but actual is {passengersAirplain1.Passengers} " +
                    $"and rejected should be 47 but actual is {passengersAirplain1.RejectedPassengers}");
                allPassed = false;
            }

            // Test 5: Upload passengers for bus
            bus.UploadPassengers(55);
            bus.UploadPassengers(5);
            if (bus.Passengers == 55 && bus.RejectedPassengers == 5)
            {
                Console.WriteLine("Test 5 Passed");
            }
            else
            {
                Console.WriteLine($"Test 5 Error - Current Passengers should be 55 but actual is {bus.Passengers} " +
                    $"and rejected should be 5 but actual is {bus.RejectedPassengers}");
                allPassed = false;
            }

            // Test 6: Check id for passengersTrain1
            if (passengersTrain1.Id == 9998774)
            {
                Console.WriteLine("Test 6 Passed");
            }
            else
            {
                Console.WriteLine($"Test 6 Error - Id should be 9998774 but actual is {passengersTrain1.Id}");
                allPassed = false;
            }

            // Test 7: Upload passengers for passengersTrain1
            passengersTrain1.UploadPassengers(300);
            passengersTrain1.UploadPassengers(134);
            if (passengersTrain1.Passengers == 434 && passengersTrain1.RejectedPassengers == 0)
            {
                Console.WriteLine("Test 7 Passed");
            }
            else
            {
                Console.WriteLine($"Test 7 Error - Current Passengers should be 434 but actual is {passengersTrain1.Passengers} " +
                    $"and rejected should be 0 but actual is {passengersTrain1.RejectedPassengers}");
                allPassed = false;
            }

            // Test 8: Attempt to exceed capacity for passengersTrain1
            passengersTrain1.UploadPassengers(405);
            if (passengersTrain1.Passengers == 700 && passengersTrain1.RejectedPassengers == 139 && !passengersTrain1.CalculateHasRoom(1))
            {
                Console.WriteLine("Test 8 Passed");
            }
            else
            {
                Console.WriteLine($"Test 8 Error - Current Passengers should be 700 but actual is {passengersTrain1.Passengers}, " +
                    $"rejected should be 139 but actual is {passengersTrain1.RejectedPassengers}, and HasRoom should be False but actual is {passengersTrain1.CalculateHasRoom(1)}");
                allPassed = false;
            }

            // Test 9: Check that each crone in passengersTrain1 is a different instance
            if (!ReferenceEquals(passengersTrain1.Crones[0], passengersTrain1.Crones[1]))
            {
                Console.WriteLine("Test 9 Passed");
            }
            else
            {
                Console.WriteLine("Test 9 Error - Each crone of the train should be a different instance.");
                allPassed = false;
            }

            Console.WriteLine("\n*********************************\n");

            // Final result
            if (allPassed)
            {
                Console.WriteLine("All TESTS PASSED - WELL DONE!!\n" +
                    "Yet it's not saying that everything works well. You should test yourself a little bit, also.");
            }
            else
            {
                Console.WriteLine("YOU HAVE FAILURES IN THE TESTS :( - SEE ABOVE");
            }

            Console.WriteLine("\n*********************************\n");
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

