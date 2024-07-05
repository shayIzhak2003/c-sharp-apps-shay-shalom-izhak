using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportation_app
{
    public class PublicVehicle
    {
       
        private int line;
        private int id;
        private int maxSpeed;
        private int seats;
        private int passengers;
        private int rejectedPassengers;

       
        public int Line { get { return line; } set { line = value; } }
        public int Id { get { return id; } set { id = value; } }
        public virtual int MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value > 40 ? 40 : value; } 
        }
        public int Seats { get { return seats; } set { seats = value; } }
        public int Passengers { get { return passengers; }  set { passengers = value; } }
        public int RejectedPassengers { get { return rejectedPassengers; }  set { rejectedPassengers = value; } }

        
        public PublicVehicle() { }

        public PublicVehicle(int line, int id, int maxSpeed, int seats)
        {
            this.line = line;
            this.id = id;
            this.maxSpeed = maxSpeed;
            this.seats = seats;
        }

        public PublicVehicle(int line, int id) : this(line, id, 40, 0) { }

        
        public virtual bool CalculateHasRoom(int additionalPassengers)
        {
            return (passengers + additionalPassengers) <= seats;
        }

        public virtual void UploadPassengers(int additionalPassengers)
        {
            if (CalculateHasRoom(additionalPassengers))
            {
                passengers += additionalPassengers;
            }
            else
            {
                int availableSpace = seats - passengers;
                passengers += availableSpace;
                rejectedPassengers += additionalPassengers - availableSpace;
            }
        }

        public override string ToString()
        {
            return $"PublicVehicle: Line={line}, Id={id}, MaxSpeed={maxSpeed}, Seats={seats}, Passengers={passengers}, RejectedPassengers={rejectedPassengers}";
        }
    }
}
