using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question3
{
    public static class questionA
    {
        public static void A()
        {
            List<string> names = new List<string>();

            while (true)
            {
                Console.Write("Enter a name (or press Enter to finish): ");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                    break;

                names.Add(name);
            }

            int count = names.Count;

            if (count == 1)
            {
                Console.WriteLine($"{names[0]} likes your post.");
            }
            else if (count == 2)
            {
                Console.WriteLine($"{names[0]} and {names[1]} like your post.");
            }
            else if (count > 2)
            {
                Console.WriteLine($"{names[0]}, {names[1]} and {count - 2} others like your post.");
            }
        }

    }
}
