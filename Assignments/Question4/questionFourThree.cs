using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question4
{


    public static class questionFourThree
    {

        /// <summary>
        /// 
        /// </summary>
        public static void FourThree()
        {
           
            Console.Write("Enter a time in 24-hour format (HH:mm): ");
            string input = Console.ReadLine();

            //// Validate input

            if (string.IsNullOrWhiteSpace(input) || !IsValidTime(input))
            {
                Console.WriteLine("Invalid Time");
            }
            else
            {
                Console.WriteLine("Ok");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        static bool IsValidTime(string time)
        {
            string[] parts = time.Split(':');

            if (parts.Length != 2)
                return false;

            if (!int.TryParse(parts[0], out int hours) || !int.TryParse(parts[1], out int minutes))
                return false;

            return hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59;
        }

    }
}
