using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question3
{
    public static class questionB
    {

        /// <summary>
        /// Write a program and ask the user to enter their name. Reverse the name and then display it.
        /// </summary>
        public static void B()

        {

            //// Ask the user to enter their name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();


            //// Validate input
            char[] charArray = name.ToCharArray(); // Convert string to character array
            Array.Reverse(charArray); // Reverse the character array
            //// Output the result
            string reversedName = new string(charArray);
            Console.WriteLine("Reversed name: " + reversedName);
        }

    }
}
