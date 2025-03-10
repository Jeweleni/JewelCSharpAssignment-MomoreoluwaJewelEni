using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question3
{

    /// <summary>
    /// Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
    /// </summary>
    public static class questionD
    {

        public static void D()
        {

            //// Ask the user to enter a few numbers separated by a hyphen
            HashSet<int> uniqueNumbers = new HashSet<int>();

            while (true)
            {
                Console.Write("Enter a number (or type 'Quit' to exit): ");
                string input = Console.ReadLine();


                if (input.Equals("Quit", StringComparison.OrdinalIgnoreCase))
                    break;

                int number = Convert.ToInt32(input);
                uniqueNumbers.Add(number);
            }

            //// Check for duplicates
            Console.WriteLine("Unique numbers entered: " + string.Join(", ", uniqueNumbers));
        }

    }
}
