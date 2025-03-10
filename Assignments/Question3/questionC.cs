using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question3
{
    public static class questionC
    {
        public static void C()
        {

            List<int> numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.Write($"Enter number {numbers.Count + 1}/5: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("You've already entered that number. Please try again.");
                    }
                    else
                    {

                        numbers.Add(number);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            numbers.Sort();

            Console.WriteLine("Sorted numbers:");
            Console.WriteLine(string.Join(", ", numbers));
        }

    }
}
