using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.bank_app
{
    public class Owner
    {
        private string FirstName;
        private string LastName;

        public string GetFirstName()
        {
            return this.FirstName;
        }
        public void SetFirstName(string firstName)
        {
            this.FirstName = firstName;
        }
        public string GetLastName()
        {
            return this.LastName;
        }
        public void SetLastName(string lastname)
        {
            this.LastName = lastname;
        }

        public Owner(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName; 
        }
    }
}
