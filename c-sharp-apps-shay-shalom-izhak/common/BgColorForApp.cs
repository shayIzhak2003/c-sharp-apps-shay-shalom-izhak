using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_shay_shalom_izhak.common
{
    public class BgColorForApp
    {
        public void ChangeBgColor()
        {
            {
                Console.WriteLine("Enter a color (Red, Green, Blue, etc.): ");
                string color = Console.ReadLine();

                try
                {
                    ConsoleColor consoleColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color, true);
                    Console.BackgroundColor = consoleColor;
                    Console.Clear(); // To refresh the console with the new color
                    Console.WriteLine($"Background color changed to {color}");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid color entered. Please enter a valid color.");
                }
            }
        }
    }
}
