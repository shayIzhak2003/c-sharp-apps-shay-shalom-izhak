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
            set
            {
                if (value > 120)
                {
                    base.MaxSpeed = 120;
                }
                else
                {
                    base.MaxSpeed = value;
                }
            }
        }

        public override void UploadPassengers(int additionalPassengers)
        {
            int bufferSeats = (int)(Seats * 0.1); // 10% buffer seats
            int availableSeats = Seats - Passengers + bufferSeats;

            if (additionalPassengers <= availableSeats)
            {
                Passengers += additionalPassengers;
            }
            else
            {
                RejectedPassengers += additionalPassengers - availableSeats;
                Passengers = Seats + bufferSeats; // Fill up to maximum capacity + buffer
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
