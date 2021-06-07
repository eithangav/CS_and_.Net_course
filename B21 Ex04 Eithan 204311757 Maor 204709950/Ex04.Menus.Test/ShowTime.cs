using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTime : IExecutable
    {
        public void PerformAction()
        {
            string currentTime = System.DateTime.Now.ToShortTimeString();

            Console.WriteLine(string.Format("The current time is: {0}", currentTime));
        }
    }
}
