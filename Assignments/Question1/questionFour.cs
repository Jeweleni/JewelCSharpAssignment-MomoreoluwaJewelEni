using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question1
{
    public static class questionFour
    {
        public static void Four()
        {

            Console.Write("Enter the speed limit (in km/hr): ");
            int speedLimit = int.Parse(Console.ReadLine());

            Console.Write("Enter the speed of the car (in km/hr): ");
            int carSpeed = int.Parse(Console.ReadLine());

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {

                int demeritPoints = (carSpeed - speedLimit) / 5;


                Console.WriteLine($"Demerit points: {demeritPoints}");


                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
            }
        }

    }
}
