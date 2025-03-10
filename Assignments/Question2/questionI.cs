using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question2
{
    /// <summary>
    /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the result on the console.
    /// </summary>
    public static class questionI
    {
 
        public static void I()
        {

            //// Count the numbers divisible by 3
            int count = 0;

            //// Loop through numbers between 1 and 100
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            //// Output the result
            Console.WriteLine($"Numbers divisible by 3 between 1and 100: {count}");
        }

    }
}
