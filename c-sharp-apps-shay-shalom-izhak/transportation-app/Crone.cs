using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.transportation_app
{
    public class Crone
    {
        
        private readonly int rows, columns;

       
        public int Rows { get { return rows; } }
        public int Columns { get { return columns; } }

       
        public Crone(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
        }

        public Crone(Crone crone)
        {
            this.rows = crone.rows;
            this.columns = crone.columns;
        }

       
        public int GetSeats()
        {
            return rows * columns;
        }

        public int GetExtras()
        {
            return rows * 2;
        }

        public override string ToString()
        {
            return $"Crone: Rows={rows}, Columns={columns}, Seats={GetSeats()}, Extras={GetExtras()}";
        }
    }
}
