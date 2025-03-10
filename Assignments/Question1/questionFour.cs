using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question1
{
    public static class questionFour
    {
        /// <summary>
        /// Write a program and ask the user to enter the speed limit. Once set, ask the user to enter the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.
        /// </summary>
        public static void Four()
        {

            //// Ask the user to enter the speed limit

            Console.Write("Enter the speed limit (in km/hr): ");
            int speedLimit = int.Parse(Console.ReadLine());

            //// Ask the user to enter the speed of the car
            Console.Write("Enter the speed of the car (in km/hr): ");
            int carSpeed = int.Parse(Console.ReadLine());

            //// Validate input
            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {

                //// Calculate the number of demerit points
                int demeritPoints = (carSpeed - speedLimit) / 5;

                Console.WriteLine($"Demerit points: {demeritPoints}");

                //// Check if the license should be suspended
               
                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
            }
        }

    }
}
