using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question1
{
    public static class questionTwo
    {
        public static void Two()
        {

            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());

            int max = (number1 > number2) ? number1 : number2;

            Console.WriteLine($"The maximum of {number1} and {number2} is: {max}");
        }

    }
}
