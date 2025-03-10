using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question1
{
    /// <summary>
    /// Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
    /// </summary>
    public static class questionThree
    {
        public static void Three()
        {
            //// Ask the user to enter the width and height of the image

            Console.Write("Enter the width of the image: ");
            int width = int.Parse(Console.ReadLine());

            //// Validate input

            Console.Write("Enter the height of the image: ");
            int height = int.Parse(Console.ReadLine());

            //// Validate input
            if (width > height)
            {
                Console.WriteLine("The image is landscape.");
            }
            //// If the height is greater than the width, the image is portrait
            else if (height > width)
            {
                Console.WriteLine("The image is portrait.");
            }
            //// If the width and height are equal, the image is square
            else
            {
                Console.WriteLine("The image is square (equal width and height).");
            }
        }

    }
}
