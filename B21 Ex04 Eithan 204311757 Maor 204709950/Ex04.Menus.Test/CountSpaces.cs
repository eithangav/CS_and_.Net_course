using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountSpaces : IExecutable
    {
        public void PerformAction()
        {
            Console.WriteLine("Please write a sentence and press 'Enter'");
            string sentence = Console.ReadLine();

            int countSpaces = 0;

            foreach (char c in sentence)
            {
                if (c == ' ')
                {
                    countSpaces++;
                }
            }

            string result = countSpaces == 1 ? string.Format("There is 1 space character in your sentence") : 
                string.Format("There are {0} space characters in your sentence", countSpaces);
            
            Console.WriteLine(result);
        }
    }
}
