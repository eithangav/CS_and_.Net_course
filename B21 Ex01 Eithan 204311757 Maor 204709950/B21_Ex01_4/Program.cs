using System;

namespace Ex01_4
{
    class Program
    {
        static void Main()
        {
            string userInputStr = readUserInput();
            printStatistics(userInputStr);

            Console.WriteLine("Press 'Enter' to exit...");
            Console.ReadLine();

        }

        /// <summary>
        /// prints all of the required statistics for the user's string
        /// </summary>
        /// <param name="i_Str"></param>
        private static void printStatistics(string i_Str)
        {
            // checks if the string is a palindrome and prints a message
            string isPalindromeStr = "is";
            if (!isPalindrome(i_Str))
            {
                isPalindromeStr = "is not";
            }
            Console.WriteLine(string.Format("The input string {0} a palindrome", isPalindromeStr));

            // in case the string is an integer, checks if the integer is divisible by 4 and prints a message
            if (isInteger(i_Str))
            {
                string isDivisibleStr = "is";
                if (!isDivisibleBy4(int.Parse(i_Str)))
                {
                    isDivisibleStr = "is not";
                }
                Console.WriteLine(string.Format("The number {0} {1} divisible by 4", i_Str, isDivisibleStr));
            }

            // in case the string is an alphabet string, prints the number ot uppercase chars in the string
            if (isAlphabetStr(i_Str))
            {
                Console.WriteLine(string.Format("There are {0} uppercase characters in the input string", countUppercaseChars(i_Str).ToString()));
            }
        }

        /// <summary>
        /// counts the number of uppercase chars in a given string
        /// </summary>
        /// <param name="i_Str"></param>
        /// <returns>the number of uppercase chars in a given string</returns>
        private static int countUppercaseChars(string i_Str)
        {
            int counter = 0;
            for(int i = 0; i < i_Str.Length; i++)
            {
                if(i_Str[i] >= 'A' && i_Str[i] <= 'Z')
                {
                    counter++;
                }
            }
            return counter;
        }

        /// <summary>
        /// checks if a given integer is divisible by 
        /// </summary>
        /// <param name="i_Num"></param>
        /// <returns>true if the number is divisible by 4, and false otherwise</returns>
        private static bool isDivisibleBy4(int i_Num)
        {
            if(i_Num % 4 == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// ---recursive method---
        /// recursively checks if a given string is a palindrome
        /// </summary>
        /// <param name="i_Str"></param>
        /// <returns>true if the string is palindrome, and false otherwise</returns>
        private static bool isPalindrome(string i_Str)
        {
            int strLength = i_Str.Length;

            // base case
            if (strLength <= 1)
            {
                return true;
            }

            // store forst and last chars
            char firstChar = i_Str[0];
            char lastChar = i_Str[strLength - 1];

            // if the first and last chars are not equal, return false
            if(firstChar != lastChar)
            {
                return false;
            }
            // if the first and last chars are equal, check the rest
            else
            {
                return isPalindrome(i_Str.Substring(1, strLength - 2));
            }
        }

        /// <summary>
        /// repeatedly reads the user's input until a valid input is inserted
        /// </summary>
        /// <returns>a valid user input</returns>
        private static string readUserInput()
        {
            Console.WriteLine("Please enter a 10 character string (English letters only or digits only)");
            string userInputStr = Console.ReadLine();

            // repeatedly ask the user for a valid input
            while (!checkValidation(userInputStr))
            {
                Console.WriteLine("Invalid input. Please enter a 10 character string (English letters only or digits only)");
                userInputStr = Console.ReadLine();
            }
            return userInputStr;
        }

        /// <summary>
        /// checks the valdation of the given string (of length 10 and alphabet chars only / digits only)
        /// </summary>
        /// <param name="i_Str"></param>
        /// <returns>true if the string is valid, and false otherwise</returns>
        private static bool checkValidation(string i_Str)
        {
            // check length
            if (i_Str.Length != 10)
            {
                return false;
            }

            if (isInteger(i_Str))
            {
                return true;
            }
            else if (isAlphabetStr(i_Str))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// checks if a given string is an alphabet string
        /// </summary>
        /// <param name="i_Str"></param>
        /// <returns>true if the given string is an alphabet string, and false otherwise</returns>
        private static bool isAlphabetStr(string i_Str)
        {
            // check that all of the chars are alphabet characters
            for (int i = 0; i < i_Str.Length; i++)
            {
                if ((i_Str[i] < 'a' || i_Str[i] > 'z') && (i_Str[i] < 'A' || i_Str[i] > 'Z'))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// checks if a given string contains only digits
        /// </summary>
        /// <param name="i_Str"></param>
        /// <returns>true if the given string contains only digits, and false otherwise</returns>
        private static bool isInteger(string i_Str)
        {
            // check that all of the chars are digits
            for (int i = 0; i < i_Str.Length; i++)
            {
                if (i_Str[i] < '0' || i_Str[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
