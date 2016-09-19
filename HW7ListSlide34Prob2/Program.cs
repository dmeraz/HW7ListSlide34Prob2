using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7ListSlide34Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instructions
            //Create the following list:
            //List<bool> boolList = new List<bool>() { true, false, false, true, false };
            //  Loop through each value
            //  If the value is true print: "Better bring an umbrella"
            //  If the value is false print: "No rain today, enjoy the sun!"

            List<bool> boolList = new List<bool>() { true, false, false, true, false };

            foreach (bool trueRain in boolList)
            {
                if (trueRain)
                {
                    Console.WriteLine("Better bring an umbrella.");
                }

                else
                {
                    Console.WriteLine("No rain today; enjoy the sun!");
                }
            }

        }
    }
}
