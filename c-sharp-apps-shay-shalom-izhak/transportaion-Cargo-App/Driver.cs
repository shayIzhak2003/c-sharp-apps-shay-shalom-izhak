using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportaion_Cargo_App
{
    public class Driver
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public CargoType CargoType { get; set; }

        public void Approve(CargoVehicle vehicle)
        {
            vehicle.ApproveTrip();
        }
    }
}
