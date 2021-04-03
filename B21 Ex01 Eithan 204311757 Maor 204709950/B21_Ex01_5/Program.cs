using System;

namespace Ex01_5
{
    class Program
    {
        static void Main()
        {
            int userInputNum = readAndParseUserInput();
            printStatistics(userInputNum);

            Console.WriteLine("Press 'Enter' to exit...");
            Console.ReadLine();
        }

        private static void printStatistics(int i_inputNum)
        {
            Console.WriteLine(string.Format("The largest digit in the number is: {0}", findBiggestDigit(i_inputNum)));
            Console.WriteLine(string.Format("The smallest digit in the number is: {0}", findSmallestDigit(i_inputNum)));
            Console.WriteLine(string.Format("{0} of the digits in the number are divisible by 3", countDivisibleBy3(i_inputNum)));
            Console.WriteLine(string.Format("{0} of the digits in the number are greater than the least significant digit ({1})", countGreaterThanLSD(i_inputNum), i_inputNum % 10));

        }

        /// <summary>
        /// reads the user's input iteratively until a valid input is inserted
        /// </summary>
        /// <returns>the parsed valid input or -1 if the parsing was failed</returns>
        private static int readAndParseUserInput()
        {
            Console.WriteLine("Enter a 6 digits number");
            string userInputStr = Console.ReadLine();
            while (!checkValidation(userInputStr))
            {
                Console.WriteLine("Invalid input. Enter a 6 digits number");
                userInputStr = Console.ReadLine();
            }

            // parsing
            int userInputInt;
            if(int.TryParse(userInputStr, out userInputInt))
            {
                return userInputInt;
            }
            return -1;
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
        /// finds the smallest digit in a given integer
        /// </summary>
        /// <param name="i_Num"></param>
        /// <returns>the smallest digit in the integer</returns>
        private static int findSmallestDigit(int i_Num)                                 // TODO: change to string input
        {
            int smallestDigit = int.MaxValue;

            while (i_Num > 0)
            {
                smallestDigit = Math.Min(smallestDigit, i_Num % 10);
                i_Num /= 10;
            }

            return smallestDigit;
        }

        /// <summary>
        /// counts the number of digits which are divisible by 3
        /// </summary>
        /// <param name="i_Num"></param>
        /// <returns>the number of digits which are divisible by 3</returns>
        private static int countDivisibleBy3(int i_Num)                                 // TODO: change to string input
        {
            int counter = 0;
            while(i_Num > 0)
            {
                int LSD = i_Num % 10;
                if (LSD % 3 == 0)
                {
                    counter++;
                }
                i_Num /= 10;
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
