﻿using System;
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
            // Allow the user to choose a background color
            Console.WriteLine("Choose a background color:");
            DisplayColorOptions();
            ConsoleColor bgColor = GetColorFromUser();

            // Set the chosen background color
            Console.BackgroundColor = bgColor;
            Console.Clear();
            Console.WriteLine("Background color changed!");
        }

        public void ChangeFontColor()
        {
            // Allow the user to choose a font color
            Console.WriteLine("Choose a font color:");
            DisplayColorOptions();
            ConsoleColor fontColor = GetColorFromUser();

            // Set the chosen font color
            Console.ForegroundColor = fontColor;
            Console.Clear();
            Console.WriteLine("Font color changed!");
        }

        private void DisplayColorOptions()
        {
            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.WriteLine($"{(int)color}. {color}");
            }
        }

        private ConsoleColor GetColorFromUser()
        {
            ConsoleColor selectedColor;
            while (true)
            {
                Console.Write("Enter the color number: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int colorNumber) && Enum.IsDefined(typeof(ConsoleColor), colorNumber))
                {
                    selectedColor = (ConsoleColor)colorNumber;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid color number. Please try again.");
                }
            }
            return selectedColor;
        }
    }
}
