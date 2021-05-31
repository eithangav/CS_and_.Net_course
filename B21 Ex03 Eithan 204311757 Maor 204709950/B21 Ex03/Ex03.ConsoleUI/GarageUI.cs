using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    public class GarageUI
    {
        private Garage m_Garage;

        public GarageUI()
        {
            m_Garage = new Garage();
        }

        private void printWelcomeMsg()
        {
            Console.WriteLine("Welcome to the Garage!");
        }

        private byte activateMenu()
        {
            Console.WriteLine(string.Format("Please choose an action: (enter a number between 1-{0})" +
                "\n1. Insert new vehicle" +
                "\n2. List the garage's plate IDs" +
                "\n3. Change vehicle's status" +
                "\n4. Inflate vehicle's wheels" +
                "\n5. Refuel a gas vehicle" +
                "\n6. Charge an electric vehicle" +
                "\n7. Show vehicle's details" +
                "\n8. Exit"));

            string userChoice = Console.ReadLine();

            return 1;
        }

        private void validateInput(string i_Input, byte i_MaxValue)
        {
            bool result = false;

            if()

            byte numInput = byte.Parse(i_Input);


            return result;
        }
    }
}
