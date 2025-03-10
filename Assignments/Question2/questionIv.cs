using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question2
{
    public static class questionIV
    {

        /// <summary>
        /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
        /// </summary>
        public static void IV()
        {

            //// Ask the user to enter a number

            Random random = new Random();
            int secretNumber = random.Next(1, 11);

            //// Display the secret number for verification
            Console.WriteLine($"Secret number (for verification): {secretNumber}");


            //// Ask the user to guess the secret number
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


            //// Output the result
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
