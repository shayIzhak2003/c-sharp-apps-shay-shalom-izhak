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

            PublicVehicle p1 = new PublicVehicle(18, 8099065, 50, 80);
            Bus bus = new Bus(1, 2033355, 110, 50, 3);
            PassengersAirplain passengersAirplain1 = new PassengersAirplain(605, 987653, 4, 10, 60, 6);
            Crone crone1 = new Crone(20, 5);
            PassengersTrain passengersTrain1 = new PassengersTrain(65, 9998774, 250, crone1, 5);

            p1.MaxSpeed = 0;
            // Test 1
            if (p1.MaxSpeed != 0)
            {
                Console.WriteLine("Test 1 Error - Max Speed should be {0} but actual is {1}", 0, p1.MaxSpeed);
                allPassed = false;
            }
            else
            {
                Console.WriteLine("Test 1 Passed ");
            }

            // Test 2
            if (bus.MaxSpeed != 110)
            {
                Console.WriteLine("Test 2 Error - Max Speed should be {0} but actual is {1}", 110, bus.MaxSpeed);
                allPassed = false;
            }
            else
            {
                Console.WriteLine("Test 2 Passed ");
            }

            // Test 3
            bus.MaxSpeed = 110;
            if (bus.MaxSpeed != 110)
            {
                Console.WriteLine("Test 3 Error - Max Speed should be {0} but actual is {1}", 110, bus.MaxSpeed);
                allPassed = false;
            }
            else
            {
                Console.WriteLine("Test 3 Passed ");
            }

            // Test 4
            passengersAirplain1.Passengers = 300;
            passengersAirplain1.UploadPassengers(100);
            if (passengersAirplain1.Passengers == 353 && passengersAirplain1.RejectedPassengers == 47)
            {
                Console.WriteLine("Test 4 Passed ");
            }
            else
            {
                Console.WriteLine("Test 4 Error - CurrentPassengers should be {0} but actual is {1} \n" +
                    "And rejected should be {2} but actual is {3} ", 353, passengersAirplain1.Passengers,
                    47, passengersAirplain1.RejectedPassengers);
                allPassed = false;
            }

            // Test 5
            bus.UploadPassengers(40);
            bus.UploadPassengers(20);
            if (bus.Passengers == 55 && bus.RejectedPassengers == 5)
            {
                Console.WriteLine("Test 5 Passed ");
            }
            else
            {
                Console.WriteLine("Test 5 Error - CurrentPassengers should be {0} but actual is {1} \n" +
                    "And rejected should be {2} but actual is {3} ", 55, bus.Passengers,
                    5, bus.RejectedPassengers);
                allPassed = false;
            }

            // Test 6
            if (passengersTrain1.Id == 9998774)
            {
                Console.WriteLine("Test 6 Passed ");
            }
            else
            {
                Console.WriteLine("Test 6 Error - id  should be {0} but actual is {1} ",
                   9998774, passengersTrain1.Id);
                allPassed = false;
            }

            // Test 7
            passengersTrain1.UploadPassengers(300);
            passengersTrain1.UploadPassengers(134);
            if (passengersTrain1.Passengers == 434 && passengersTrain1.RejectedPassengers == 0)
            {
                Console.WriteLine("Test 7 Passed ");
            }
            else
            {
                Console.WriteLine("Test 7 Error - CurrentPassengers should be {0} but actual is {1} \n" +
                    "And rejected should be {2} but actual is {3} ", 434, passengersTrain1.Passengers,
                    0, passengersTrain1.RejectedPassengers);
                allPassed = false;
            }

            // Test 8
            passengersTrain1.UploadPassengers(405);
            if (passengersTrain1.Passengers == 700 && passengersTrain1.RejectedPassengers == 139
                && !passengersTrain1.HasRoom)
            {
                Console.WriteLine("Test 8 Passed ");
            }
            else
            {
                Console.WriteLine("Test 8 Error - CurrentPassengers should be {0} but actual is {1} \n" +
                    "And rejected should be {2} but actual is {3} and HasRoom should be False, but actual is {4}", 700, passengersTrain1.Passengers,
                    139, passengersTrain1.RejectedPassengers, passengersTrain1.HasRoom);
                allPassed = false;
            }

            // Test 9
            if (passengersTrain1.Crones[0].Equals(passengersTrain1.Crones[1]))
            {
                Console.WriteLine("Test 9 Error - each crone of the train should be different instance. ");
                allPassed = false;
            }
            else
            {
                Console.WriteLine("Test 9 Passed");
            }

            Console.WriteLine("\n*********************************\n");

            if (allPassed)
            {
                Console.WriteLine("All TEST PASSED - WELL DONE!! \n" +
                    "Yet it's not saying that everything work well. You should test yourself a little bit, also.");
            }
            else
            {
                Console.WriteLine("YOU HAVE FAILURES AT THE TESTS :( - SEE ABOVE");
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

