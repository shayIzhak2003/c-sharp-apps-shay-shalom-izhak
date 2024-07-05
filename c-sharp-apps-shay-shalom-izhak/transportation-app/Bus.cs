using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportation_app
{
    public class Bus : PublicVehicle
    {
       
        private readonly int doors;
        private bool bellStop = false;

        
        public int Doors { get { return doors; } }
        public bool BellStop { get { return bellStop; } set { bellStop = value; } }

       
        public Bus() { }

        public Bus(int line, int id, int maxSpeed, int seats, int doors)
            : base(line, id, maxSpeed, seats)
        {
            this.doors = doors;
        }

       
        public override int MaxSpeed
        {
            get { return base.MaxSpeed; }
            set { base.MaxSpeed = value > 120 ? 120 : value; }
        }

        public override void UploadPassengers(int additionalPassengers)
        {
            int maxPassengers = (int)Math.Ceiling(Seats * 1.1);
            if (Passengers + additionalPassengers <= maxPassengers)
            {
                Passengers += additionalPassengers;
            }
            else
            {
                int availableSpace = maxPassengers - Passengers;
                Passengers += availableSpace;
                RejectedPassengers += additionalPassengers - availableSpace;
            }
        }

        public void RingBell()
        {
            bellStop = true;
        }

        public override string ToString()
        {
            return base.ToString() + $", Doors={doors}, BellStop={bellStop}";
        }
    }
}
