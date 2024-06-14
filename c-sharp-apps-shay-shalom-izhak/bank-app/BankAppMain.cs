using c_sharp_apps_shay_shalom_izhak.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.bank_app
{
    public class BankAppMain
    {
        public static void MainEntry()
        {
            Console.WriteLine("this is “BankApp”");
            Console.WriteLine();
            BgColorForApp bgColorForApp = new BgColorForApp();
            bgColorForApp.ChangeBgAndFontColor();
            Console.WriteLine("\nWelcome To SportApp!");
            Console.WriteLine();
            TestAccount.Test1();
        }
    }
}
