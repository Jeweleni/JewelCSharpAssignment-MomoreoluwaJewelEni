using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question4
{
    public static class questionFourOne
    {
        public static void FourOne()
        {
            Console.Write("Enter a few numbers separated by a hyphen: ");
            string input = Console.ReadLine();

            string[] numberStrings = input.Split('-');

            int[] numbers = numberStrings.Select(s => int.Parse(s)).ToArray();

            bool isConsecutive = true;

            int direction = numbers[1] - numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] - numbers[i - 1] != direction)
                {
                    isConsecutive = false;
                    break;
                }
            }

            if (isConsecutive)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
        }

    }
}
