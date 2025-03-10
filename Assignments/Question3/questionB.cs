using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question3
{
    public static class questionB
    {
        public static void B()

        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            char[] charArray = name.ToCharArray(); // Convert string to character array
            Array.Reverse(charArray); // Reverse the character array
            string reversedName = new string(charArray);
            Console.WriteLine("Reversed name: " + reversedName);
        }

    }
}
