using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question2
{
    public static class questionIII
    {
        public static void III()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            for (int i = number; i > 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine($"{number}! = {factorial}");
        }

    }
}
