using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question3
{
    public static class questionD
    {
        public static void D()
        {
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

            Console.WriteLine("Unique numbers entered: " + string.Join(", ", uniqueNumbers));
        }

    }
}
