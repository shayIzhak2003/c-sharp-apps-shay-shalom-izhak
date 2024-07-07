using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportation_app
{
    public class PassengersAirplain : PublicVehicle
    {
        private int enginesNum;
        private int wingLength;
        private int rows;
        private int columns;

        public int EnginesNum { get { return enginesNum; } set { enginesNum = value; } }
        public int WingLength { get { return wingLength; } set { wingLength = value; } }
        public int Rows { get { return rows; } set { rows = value; } }
        public int Columns { get { return columns; } set { columns = value; } }

        public PassengersAirplain() { }

        public PassengersAirplain(int line, int id, int enginesNum, int wingLength, int rows, int columns)
            : base(line, id, 0, rows * columns - 7)
        {
            this.enginesNum = enginesNum;
            this.wingLength = wingLength;
            this.rows = rows;
            this.columns = columns;
        }

        public override void UploadPassengers(int additionalPassengers)
        {
            int availableSeats = Seats - Passengers;
            if (additionalPassengers <= availableSeats)
            {
                Passengers += additionalPassengers;
            }
            else
            {
                Passengers += availableSeats;
                RejectedPassengers += additionalPassengers - availableSeats;
                HasRoom = false;
            }
        }

        public override int MaxSpeed
        {
            get { return base.MaxSpeed; }
            set { base.MaxSpeed = value > 1000 ? 1000 : value; }
        }

        public override string ToString()
        {
            return base.ToString() + $", EnginesNum={enginesNum}, WingLength={wingLength}, Rows={rows}, Columns={columns}";
        }
    }
}
