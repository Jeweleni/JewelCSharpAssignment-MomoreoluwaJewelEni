using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question2
{
    public static class questionIV
    {
        public static void IV()
        {

            Random random = new Random();
            int secretNumber = random.Next(1, 11);

            Console.WriteLine($"Secret number (for verification): {secretNumber}");

            bool hasWon = false;
            for (int attempt = 1; attempt <= 4; attempt++)
            {
                Console.Write($"Attempt {attempt}: Enter your guess (1-10): ");
                int guess = int.Parse(Console.ReadLine());

                if (guess == secretNumber)
                {
                    hasWon = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect guess. Try again.");
                }
            }

            if (hasWon)
            {
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine("You lost. Better luck next time!");
            }
        }

    }
}
