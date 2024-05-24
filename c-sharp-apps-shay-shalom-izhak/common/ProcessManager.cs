using c_sharp_apps_shay_shalom_izhak.bank_app;
using c_sharp_apps_shay_shalom_izhak.draft_app;
using c_sharp_apps_shay_shalom_izhak.sport_app;
using c_sharp_apps_shay_shalom_izhak.transportation_app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.common
{
    public class ProcessManager
    {
        public static void MainProcess()
        {
            while(true)
            {
                Console.WriteLine("choose your app \n 1.BankApp  \n 2.SportApp  \n 3.DraftApp \n 4.TransportationApp \n 0.Exit");
                int choose = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (choose)
                {
                    case 1:
                        BankAppMain.MainEntry();
                        break;

                    case 2:
                        SportAppMain.MainEntry();
                        break;

                    case 3:
                        DraftAppMain.MainEntry();
                        break;

                    case 4:
                        TransportationAppMain.MainEntry();
                        break;

                    case 0:
                        Console.WriteLine("the loop was breaked!");
                        return;

                    default:
                        Console.WriteLine("Error! invalid Choise");
                        break;


                }
            }
          

        }
    }
}
