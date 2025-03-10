using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question4
{
    public static class questionFourTwo
    {
        public static void FourTwo()
        {
            Console.Write("Enter a few numbers separated by a hyphen (or press Enter to exit): ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                return;

            int[] numbers = input.Split('-').Select(n => Convert.ToInt32(n)).ToArray();
            HashSet<int> uniqueNumbers = new HashSet<int>();

            foreach (int number in numbers)
            {
                if (!uniqueNumbers.Add(number))
                {
                    Console.WriteLine("Duplicate");
                    return;
                }
            }

            Console.WriteLine("No Duplicates");
        }

    }
}
