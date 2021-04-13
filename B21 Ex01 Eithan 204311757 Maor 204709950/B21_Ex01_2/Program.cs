using System;
using System.Text;

namespace Ex01_2
{
    public class Program
    {
        public static void Main()
        {
            // prints the sandClock of numberOfStars = 5
            PrintSandClock(5, 5);

            Console.WriteLine("Press 'Enter' to exit");
            Console.ReadLine();
        }

        /// <summary>
        /// ---recursive method---
        /// recursively prints the desired sandClock of *
        /// </summary>
        /// <param name="i_NumOfStars">helper parm for the recursive call</param>
        /// <param name="i_NumOfLines">the desired number of liness of stars</param>
        public static void PrintSandClock(int i_NumOfStars, int i_NumOfLines)
        {
            // base condition
            if(i_NumOfStars <= 1)
            {
                PrintStarsLine(1, i_NumOfLines);

                return;
            }

            // prints the current line of stars
            PrintStarsLine(i_NumOfStars, i_NumOfLines);

            // the recursive call
            PrintSandClock(i_NumOfStars - 2, i_NumOfLines);

            // prints the current line of stars
            PrintStarsLine(i_NumOfStars, i_NumOfLines);
        }

        /// <summary>
        /// prints the desired number of stars and appends spaces in the beginning and in the end of the line
        /// </summary>
        /// <param name="i_NumOfStars"></param>
        /// <param name="i_NumOfChars"></param>
        public static void PrintStarsLine(int i_NumOfStars, int i_NumOfChars)
        {
            // the number of spaces at the beginning and at the end of the line
            int numOfSpaces = (i_NumOfChars - i_NumOfStars) / 2;

            // used to create the line of spaces and stars
            StringBuilder lineOutput = new StringBuilder();

            // appends spaces at the beginning of the line
            for (int i = 0; i < numOfSpaces; i++)
            {
                lineOutput.Append(" ");
            }

            // appends the current amount of stars 
            for (int i = 0; i < i_NumOfStars; i++)
            {
                lineOutput.Append("*");
            }

            // appends spaces at the end of the line
            for (int i = 0; i < numOfSpaces; i++)
            {
                lineOutput.Append(" ");
            }

            // prints the total line of spaces and stars
            Console.WriteLine(lineOutput.ToString());
        }

    }
}
