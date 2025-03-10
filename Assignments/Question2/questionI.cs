using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question2
{
    public static class questionI
    {
        public static void I()
        {
            int count = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Numbers divisible by 3 between 1and 100: {count}");
        }

    }
}
