
using System;
using System.Text;

namespace Ex01_1
{
    public class Program
    {
        public static void Main()
        {
            // hello message
            Console.WriteLine("Hello. Please insert 3 binary numbers (7 digits length each)");

            // read the user's binary numbers
            string decimalNumber1 = readUsersBinaryString();
            string decimalNumber2 = readUsersBinaryString();
            string decimalNumber3 = readUsersBinaryString();

            // print the decimal representation of the 3 numbers and all the required statistics
            printStatistics(decimalNumber1, decimalNumber2, decimalNumber3);

            // waits for the user to end the program
            Console.WriteLine("Press 'Enter' to exit");
            Console.ReadLine();
        }

        /// <summary>
        /// reads a string input from the user
        /// handles invalid inputs by re-reading
        /// </summary>
        /// <returns>a valid binary string</returns>
        private static string readUsersBinaryString()
        {
            Console.WriteLine("Insert a binary number and press 'Enter'");
            string binaryStr = Console.ReadLine();
            while (!checkNumberValidation(binaryStr))
            {
                Console.WriteLine("Invalid binary number format. Please try again and press 'Enter'");
                binaryStr = Console.ReadLine();
            }
            return binaryStr;
        }

        /// <summary>
        /// converts a given binary string of length 7 to decimal number
        /// </summary>
        /// <param name="i_BinaryStr"></param>
        /// <returns>the decimal number stored in 'byte' variable</returns>
        private static byte binaryStringToDeminal(string i_BinaryStr)
        {
            byte decimalNumber = 0;
            for(int i = 0; i < i_BinaryStr.Length; i++)
            {
                decimalNumber += (byte)(Math.Pow(2, i_BinaryStr.Length - i - 1) * (i_BinaryStr[i] - '0'));
            }
            return decimalNumber;
        }

        /// <summary>
        /// checks if a given string is of length 7 and in binary representation
        /// </summary>
        /// <param name="i_BinaryNumber"></param>
        /// <returns>true if valid, and false otherwise</returns>
        private static bool checkNumberValidation(string i_BinaryNumber)
        {
            // characters validation
            for (int i = 0; i < i_BinaryNumber.Length; i++)
            {
                if(i_BinaryNumber[i] != '0' && i_BinaryNumber[i] != '1')
                {
                    return false;
                }
            }
            // length validation
            return (i_BinaryNumber.Length == 7);
        }

        /// <summary>
        /// prints the statistics of the given 3 binary strings
        /// </summary>
        /// <param name="i_BinaryStr1"></param>
        /// <param name="i_BinaryStr2"></param>
        /// <param name="i_BinaryStr3"></param>
        private static void printStatistics(string i_BinaryStr1, string i_BinaryStr2, string i_BinaryStr3)
        {
            // convert the binary strings to decimal bytes and print a message
            byte decimalNumber1 = binaryStringToDeminal(i_BinaryStr1);
            byte decimalNumber2 = binaryStringToDeminal(i_BinaryStr2);
            byte decimalNumber3 = binaryStringToDeminal(i_BinaryStr3);
            string decimalNumbersMsg = string.Format("The decimal numbers are: {0}, {1}, {2}", decimalNumber1, decimalNumber2, decimalNumber3);
            Console.WriteLine(decimalNumbersMsg);

            // calculate the avarage number of zeros appearances in all of the numbers and print a message
            byte zerosAvg = calculateAvgAppearance(i_BinaryStr1, i_BinaryStr2, i_BinaryStr3, '0');
            string zerosAvgMsg = string.Format("The average number of zeros is: {0}", zerosAvg);
            Console.WriteLine(zerosAvgMsg);

            // calculate the avarage number of ones appearances in all of the numbers and print a message
            byte onesAvg = calculateAvgAppearance(i_BinaryStr1, i_BinaryStr2, i_BinaryStr3, '1');
            string onesAvgMsg = string.Format("The average number of ones is: {0}", onesAvg);
            Console.WriteLine(onesAvgMsg);

            // calculate how many numbers are a power of 2 and print a message
            byte powerOf2Counter = (byte)(isPowerOf2(decimalNumber1) + isPowerOf2(decimalNumber2) + isPowerOf2(decimalNumber3));
            string powerOf2Msg = string.Format("There are {0} numbers which are a power of 2", powerOf2Counter);
            Console.WriteLine(powerOf2Msg);

            // find min and max numbers and print a message
            byte minNumber = findMin(decimalNumber1, decimalNumber2, decimalNumber3);
            byte maxNumber = findMax(decimalNumber1, decimalNumber2, decimalNumber3);
            string minAndMaxMsg = string.Format("The biggest number is {0} and the smallest number is {1}", maxNumber, minNumber);
            Console.WriteLine(minAndMaxMsg);

            // calculate how many numbers has an ascending order of digits and print a message
            byte numOfAscendingDigits = (byte)(isAscendingDigits(decimalNumber1) + isAscendingDigits(decimalNumber2) + isAscendingDigits(decimalNumber3));
            string countAscendingMsg = string.Format("There are {0} numbers with ascending digits in the decimal representation", numOfAscendingDigits);
            Console.WriteLine(countAscendingMsg);
        }

        /// <summary>
        /// checks if the digits of a given number are placed in an ascending order
        /// </summary>
        /// <param name="i_Num"></param>
        /// <returns>1 if true, and 0 othewise</returns>
        private static byte isAscendingDigits(byte i_Num)
        {
            byte lastDigit;
            while(i_Num > 0)
            {
                lastDigit = (byte)(i_Num % 10);
                i_Num /= 10;
                if(lastDigit <= i_Num % 10)
                {
                    return 0;
                }
            }
            return 1;
        }

        /// <summary>
        /// finds the minimum of 3 byte numbers
        /// </summary>
        /// <param name="i_Num1"></param>
        /// <param name="i_Num2"></param>
        /// <param name="i_Num3"></param>
        /// <returns>the minimum</returns>
        private static byte findMin(byte i_Num1, byte i_Num2, byte i_Num3)
        {
            byte min = Math.Min(i_Num1, i_Num2);
            return Math.Min(min, i_Num3);
        }

        /// <summary>
        /// finds the maximum of 3 byte numbers
        /// </summary>
        /// <param name="i_Num1"></param>
        /// <param name="i_Num2"></param>
        /// <param name="i_Num3"></param>
        /// <returns>the maximum</returns>
        private static byte findMax(byte i_Num1, byte i_Num2, byte i_Num3)
        {
            byte max = Math.Max(i_Num1, i_Num2);
            return Math.Max(max, i_Num3);
        }

        /// <summary>
        /// checks if a given number is a power of 2
        /// </summary>
        /// <param name="i_Num"></param>
        /// <returns>1 if the number is a power of 2, and 0 otherwise</returns>
        private static byte isPowerOf2(byte i_Num)
        {
            while(i_Num > 1)
            {
                if(i_Num % 2 != 0)
                {
                    return 0;
                }
                i_Num /= 2;
            }
            return 1;
        }

        /// <summary>
        /// calculates the average number of appearances of a char in three strings
        /// </summary>
        /// <param name="i_Str1"></param>
        /// <param name="i_Str2"></param>
        /// <param name="i_Str3"></param>
        /// <param name="i_Char"></param>
        /// <returns>the calculated average number</returns>
        private static byte calculateAvgAppearance(string i_Str1, string i_Str2, string i_Str3, char i_Char)
        {
            // concatenates the given 3 strings
            StringBuilder numbersConcat = new StringBuilder();
            numbersConcat.Append(i_Str1);
            numbersConcat.Append(i_Str2);
            numbersConcat.Append(i_Str3);

            // uses helper method to count the number of appearances
            byte sumOfAppearance = countAppearance(numbersConcat.ToString(), i_Char);
            // returns the average (dividing by 3)
            return (byte)(sumOfAppearance / 3);
        }

        /// <summary>
        /// counts the number of apearances of a given char in a string
        /// </summary>
        /// <param name="i_Str">the string to check in</param>
        /// <param name="i_Char">the char to count</param>
        /// <returns>the number of appearances</returns>
        private static byte countAppearance(string i_Str, char i_Char)
        {
            byte counter = 0;
            for(int i = 0; i < i_Str.Length; i++)
            {
                if(i_Str[i] == i_Char)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
    