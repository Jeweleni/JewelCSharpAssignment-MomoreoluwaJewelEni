using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question2
{
    public static class questionII
    {
        public static void II()
        {
            int sum = 0;

            while (true)
            {

                Console.Write("Enter a number or 'ok' to exit: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "ok")
                {
                    break;
                }

                if (int.TryParse(input, out int number))
                {
                    sum += number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number or 'ok' to exit.");
                }
            }
            Console.WriteLine($"The sum of all entered numbers is: {sum}");
        }

    }
}
