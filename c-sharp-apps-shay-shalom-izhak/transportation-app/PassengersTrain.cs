using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportation_app
{
    public class PassengersTrain : PublicVehicle
    {
        
        private Crone[] crones;
        private int cronesAmount;

        
        public Crone[] Crones { get { return crones; } }
        public int CronesAmount { get { return cronesAmount; } }

        
        public PassengersTrain()
        {
            crones = new Crone[0];
        }

        public PassengersTrain(int line, int id, int maxSpeed, Crone crone, int cronesAmount)
            : base(line, id, maxSpeed, 0)
        {
            this.cronesAmount = cronesAmount;
            crones = new Crone[cronesAmount];
            for (int i = 0; i < cronesAmount; i++)
            {
                crones[i] = new Crone(crone);
            }
            CalculateSeats();
        }

        
        private void CalculateSeats()
        {
            Seats = 0;
            foreach (var crone in crones)
            {
                Seats += crone.GetSeats() + crone.GetExtras();
            }
        }

        public override void UploadPassengers(int additionalPassengers)
        {
            if (CalculateHasRoom(additionalPassengers))
            {
                Passengers += additionalPassengers;
            }
            else
            {
                int availableSpace = Seats - Passengers;
                Passengers += availableSpace;
                RejectedPassengers += additionalPassengers - availableSpace;
            }
        }

        public override int MaxSpeed
        {
            get { return base.MaxSpeed; }
            set { base.MaxSpeed = value > 300 ? 300 : value; }
        }

        public override string ToString()
        {
            return base.ToString() + $", CronesAmount={cronesAmount}";
        }
    }
}
