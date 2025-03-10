using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment.Question_5
{

   
    public static class questionFive
    {

        /// <summary>
        /// Counts the number of words in a file
        /// </summary>
        public static void CountWordsInFile()
        {

            
            Console.Write("Enter file path: ");
            var filePath = Console.ReadLine();

            /// Check if file exists        
           
            if (File.Exists(filePath))
            {
                var words = File.ReadAllText(filePath).Split(' ', '\n', '\t').Length;
                Console.WriteLine($"Word count: {words}");
            }
            /// If file does not exist
            else
                Console.WriteLine("File not found");
        }

        /// <summary>
        /// Finds the longest word in a file
        /// </summary>
        public static void FindLongestWordInFile()
        {

            /// Get file path from user
            Console.Write("Enter file path: ");
            var filePath = Console.ReadLine();

            /// Check if file exists
            if (File.Exists(filePath))
            {
                var longestWord = File.ReadAllText(filePath).Split(' ', '\n', '\t').OrderByDescending(w => w.Length).First();
                Console.WriteLine($"Longest word: {longestWord}");
            }

            /// If file does not exist
            else
                Console.WriteLine("File not found");
        }

    }
}
