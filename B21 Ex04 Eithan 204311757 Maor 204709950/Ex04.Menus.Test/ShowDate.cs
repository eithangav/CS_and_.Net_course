using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDate : IExecutable
    {
        public void PerformAction()
        {
            string currentDate = System.DateTime.Now.ToShortDateString();

            Console.WriteLine(string.Format("The current date is: {0}", currentDate));
        }
    }
}
