using System;
using Ex01_2;

namespace Ex01_3
{
    class Program
    {
        static void Main()
        {
            int numOfLines = readUserInput();
            Ex01_2.Program.printSandClock(numOfLines, numOfLines);
            Console.WriteLine("Press 'Enter' to exit...");
            Console.ReadLine();

        }

        /// <summary>
        /// reads user's input. If the input is even, increments by 1.
        /// </summary>
        /// <returns></returns>
        private static int readUserInput()
        {
            Console.WriteLine("Please enter the number of lines for the sand machine:");
            string userInputStr = Console.ReadLine();

            // repeatedly ask the user for a valid input
            while (!checkValidation(userInputStr))
            {
                Console.WriteLine("Invalid input. Please enter the number of lines for the sand machine:");
                userInputStr = Console.ReadLine();
            }

            // parse the input to integer
            int userInput = int.Parse(userInputStr);

            // verify that the input is an odd number
            if(userInput % 2 == 0)
            {
                userInput++;
            }

            return userInput;

        }

        /// <summary>
        /// checks if all of the chars of a string are digit chars
        /// </summary>
        /// <param name="i_Str"></param>
        /// <returns>true if all of the chars are digits, and false otherwise</returns>
        private static bool checkValidation(string i_Str)
        {
            for(int i = 0; i < i_Str.Length; i++)
            {
                if(i_Str[i] < '0' || i_Str[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
