using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question1
{
    public static class questionThree
    {
        public static void Three()
        {

            Console.Write("Enter the width of the image: ");
            int width = int.Parse(Console.ReadLine());


            Console.Write("Enter the height of the image: ");
            int height = int.Parse(Console.ReadLine());


            if (width > height)
            {
                Console.WriteLine("The image is landscape.");
            }
            else if (height > width)
            {
                Console.WriteLine("The image is portrait.");
            }
            else
            {
                Console.WriteLine("The image is square (equal width and height).");
            }
        }

    }
}
