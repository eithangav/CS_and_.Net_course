using System;

namespace Ex01_5
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
        /// prints statistics of the input number
        /// </summary>
        /// <param name="i_inputStr"></param>
        private static void printStatistics(string i_InputStr)
        {
            // try to parse the input string to integer, if failed print an error
            int userInputNum;

            if (!int.TryParse(i_InputStr, out userInputNum))
            {
                Console.WriteLine("Error. Could not parse the input string");
                return;
            }

            // if parsing succeeded, difines string messages
            String largestDigitMsg = string.Format("The largest digit in the number is: {0}", findBiggestDigit(userInputNum));
            String smallestDigitMsg = string.Format("The smallest digit in the number is: {0}", findSmallestDigit(i_InputStr));
            String divisibleBy3Msg = string.Format("{0} of the digits in the number are divisible by 3", countDivisibleBy3(i_InputStr));
            String greaterThanLsbMsg = string.Format("{0} of the digits in the number are greater than the least significant digit ({1})", countGreaterThanLSD(userInputNum), userInputNum % 10);

            // prints messages
            Console.WriteLine(largestDigitMsg);
            Console.WriteLine(smallestDigitMsg);
            Console.WriteLine(divisibleBy3Msg);
            Console.WriteLine(greaterThanLsbMsg);
        }

        /// <summary>
        /// reads the user's input iteratively until a valid input is inserted
        /// </summary>
        /// <returns>the valid input string</returns>
        private static string readUserInput()
        {
            Console.WriteLine("Enter a 6 digits number");

            string userInputStr = Console.ReadLine();

            while (!checkValidation(userInputStr))
            {
                Console.WriteLine("Invalid input. Enter a 6 digits number");
                userInputStr = Console.ReadLine();
            }

            return userInputStr;
        }

        /// <summary>
        /// checks if a given string is a 6 digits positive number
        /// </summary>
        /// <param name="i_Str"></param>
        /// <returns>true if the string is valid, and false otherwise</returns>
        private static bool checkValidation(string i_Str)
        {
            // checks length
            if(i_Str.Length != 6)
            {
                return false;
            }

            // checks that all chars are digits and that there is at least one digit that is positive
            bool nonZeroDigitExsists = false;

            for(int i = 0; i < i_Str.Length; i++)
            {
                if(i_Str[i] < '0' || i_Str[i] > '9')
                {
                    return false;
                }
                if(!nonZeroDigitExsists && i_Str[i] >= '1' && i_Str[i] <= '9')
                {
                    nonZeroDigitExsists = true;
                }
            }

            return nonZeroDigitExsists;
        }

        /// <summary>
        /// finds the biggest digit in a given integer
        /// </summary>
        /// <param name="i_Num"></param>
        /// <returns>the biggest digit in the integer</returns>
        private static int findBiggestDigit(int i_Num)
        {
            int biggestDigit = 0;

            while(i_Num > 0)
            {
                biggestDigit = Math.Max(biggestDigit, i_Num % 10);
                i_Num /= 10;
            }

            return biggestDigit;
        }

        /// <summary>
        /// finds the smallest digit in a given number represented by a string
        /// </summary>
        /// <param name="i_Num"></param>
        /// <returns>the smallest digit in the integer</returns>
        private static int findSmallestDigit(string i_NumStr)
        {
            char smallestDigitChar = '9';

            for(int i = 0; i < i_NumStr.Length; i++)
            {
                if(i_NumStr[i] < smallestDigitChar)
                {
                    smallestDigitChar = i_NumStr[i];
                }
            }

            int smallestDigitInt = smallestDigitChar - '0';

            return smallestDigitInt;
        }

        /// <summary>
        /// counts the number of digits (in a given number represented by a string) that are divisible by 3
        /// </summary>
        /// <param name="i_NumStr"></param>
        /// <returns>the number of digits which are divisible by 3</returns>
        private static int countDivisibleBy3(string i_NumStr)
        {
            int counter = 0;

            for (int i = 0; i < i_NumStr.Length; i++)
            {
                int currentDigit = i_NumStr[i] - '0';

                if (currentDigit % 3 == 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        /// <summary>
        /// counts the number of digits which are greater than the least significant digit
        /// </summary>
        /// <param name="i_Num"></param>
        /// <returns>the number of digits which are greater than the least significant digit</returns>
        private static int countGreaterThanLSD(int i_Num)
        {
            int LSD = i_Num % 10;
            i_Num /= 10;
            int counter = 0;

            while (i_Num > 0)
            {
                if (i_Num % 10 > LSD)
                {
                    counter++;
                }

                i_Num /= 10;
            }

            return counter;
        }
    }
}
