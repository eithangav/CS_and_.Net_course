using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersion : IExecutable
    {
        public void PerformAction()
        {
            Console.WriteLine("Version: 21.1.4.8930");
        }
    }
}
