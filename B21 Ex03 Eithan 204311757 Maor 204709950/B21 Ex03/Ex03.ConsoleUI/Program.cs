using System;

namespace Ex03.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Format("Please choose an action from the following menu: (enter the correspinding number)" +
                "1. Insert new vehicle" +
                "2. List the garage's plate IDs" +
                "3. Change vehicle's status" +
                "4. Inflate vehicle's wheels" +
                "5. Refuel a gas vehicle" +
                "6. Charge an electric vehicle" +
                "7. Show vehicle's details"));
        }
    }
}
