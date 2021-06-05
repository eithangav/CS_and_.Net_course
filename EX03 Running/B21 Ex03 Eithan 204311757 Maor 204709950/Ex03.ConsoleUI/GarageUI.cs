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

            LunchConsoleUI();
        }

        private void LunchConsoleUI()
        {
            Console.WriteLine("Welcome to the Garage!");

            while (true)
            {
                MainMenu();                
            }
        }

        private void MainMenu()
        {
            Console.WriteLine("Please choose an action: (enter a number between 1-8)" +
                "\n1. Insert new vehicle" +
                "\n2. List the garage's plate IDs" +
                "\n3. Change vehicle's status" +
                "\n4. Inflate vehicle's wheels" +
                "\n5. Refuel a gas vehicle" +
                "\n6. Charge an electric vehicle" +
                "\n7. Show vehicle's details" +
                "\n8. Exit");

            byte sectionToExecute = readAndValidateMenuChoiceInput(8);

            switch (sectionToExecute)
            {
                case 1:
                    insertNewVehicle();
                    break;
                case 2:
                    showGaragePlatesId();
                    break;
                case 3:
                    changeVehicleState();
                    break;
                case 4:
                    inflateWheels();
                    break;
                case 5:
                    refuelGasVehicle();
                    break;
                case 6:
                    chargeElectricVehicle();
                    break;
                case 7:
                    showVehicleDetails();
                    break;
                case 8:
                    killConsoleUI();
                    break;
            }
        }

        private byte readAndValidateMenuChoiceInput(byte i_MaxValue)
        {
            string userChoice;
            byte userChoiceNum = 0;
            string invalidInputMsg = string.Format("Invalid input. Please enter a number in range (1-{0})", i_MaxValue);

            while (userChoiceNum == 0)
            {
                userChoice = Console.ReadLine();

                try
                {
                    userChoiceNum = byte.Parse(userChoice);

                    if (userChoiceNum < 1 || userChoiceNum > i_MaxValue)
                    {
                        userChoiceNum = 0;
                        Console.WriteLine(invalidInputMsg);
                    }
                }
                catch
                {
                    userChoiceNum = 0;
                    Console.WriteLine(invalidInputMsg);
                }
            }

            return userChoiceNum;
        }

        private string readAndValidateStringInput(bool i_CheckPlateIdExistant = false)
        {
            string inputStr = "";

            while(inputStr == "")
            {
                try
                {
                    inputStr = Console.ReadLine();

                    if (inputStr == "")
                    {
                        Console.WriteLine("Invalid input. Please enter a non-empty string");
                    }
                    else if (i_CheckPlateIdExistant && !m_Garage.VehicleExists(inputStr))
                    {
                        Console.WriteLine("Plate ID doesn't exist. Please try again");
                        inputStr = "";
                    }
                }
                catch
                {
                    Console.WriteLine("An error occured. Please try again...");
                }
                
            }

            return inputStr;
        }

        private float readAndValidateNonNegativeNumInput(bool i_RequiredPositive = false, bool i_RequiredInteger = false)
        {
            string inputStr;
            float inputNum = -1;

            string numPositivity = "non-negative";
            string numType = "number";

            if (i_RequiredPositive)
            {
                numPositivity = "positive";
            }

            if (i_RequiredInteger)
            {
                numType = "integer";
            }

            string invalidInputMsg = string.Format("Invalid input. Please enter a {0} {1}", numPositivity, numType);

            while (inputNum == -1)
            {
                inputStr = Console.ReadLine();

                try
                {
                    inputNum = float.Parse(inputStr);

                    if (inputNum < 0 || (i_RequiredPositive && inputNum == 0) || (i_RequiredPositive && inputNum - (float)((int)inputNum) != 0))
                    {
                        inputNum = -1;
                        Console.WriteLine(invalidInputMsg);
                    }
                }
                catch
                {
                    inputNum = -1;
                    Console.WriteLine(invalidInputMsg);
                }
            }

            return inputNum;
        }

        private void insertNewVehicle()
        {
            try
            {
                Console.WriteLine("Insert the vehicle's Plate ID:");
                string plateId = Console.ReadLine();

                if (m_Garage.VehicleExists(plateId))
                {
                    m_Garage.ChangeVehicleState(plateId, VehicleStatus.InProgress);
                    Console.WriteLine("This plate ID already exists. It's vehicle's status was updated to 'In proress'");
                }
                else
                {
                    vehicleInsertionMenu(plateId);
                    Console.WriteLine("The vehicle was inserted successfully");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("An error occured. Please try again....");
            }
        }

        private void vehicleInsertionMenu(string i_PlateId)
        {
            Console.WriteLine("Which vehicle would you like to insert? (enter a number between 1-5)" +
                       "\n1. Gas car" +
                       "\n2. Electric car" +
                       "\n3. Gas motorcycle" +
                       "\n4. Electric motorcycle" +
                       "\n5. Truck");

            byte chosenSection = readAndValidateMenuChoiceInput(5);

            switch (chosenSection)
            {
                case 1:
                    insertVehicleByType(i_PlateId, VehicleType.GasCar);
                    break;
                case 2:
                    insertVehicleByType(i_PlateId, VehicleType.ElectricCar);
                    break;
                case 3:
                    insertVehicleByType(i_PlateId, VehicleType.GasMotorcycle);
                    break;
                case 4:
                    insertVehicleByType(i_PlateId, VehicleType.ElectricMotorcycle);
                    break;
                case 5:
                    insertVehicleByType(i_PlateId, VehicleType.Truck);
                    break;
            }
        }

        private void insertVehicleByType(string i_PlateId, VehicleType i_VehicleType)
        {
            string vehicleType = stringifyVehicleType(i_VehicleType);

            // Read shared properties:

            Console.WriteLine("Enter customer's name:");
            string customerName = readAndValidateStringInput();

            Console.WriteLine("Enter customer's phone:");
            string customerPhone = readAndValidateStringInput();

            Console.WriteLine(string.Format("Enter the {0}'s model:", vehicleType));
            string model = readAndValidateStringInput();

            string[] wheelsManucafturers;
            float[] wheelsCurrentAirPressures;
            readWheelsProperties(i_VehicleType, out wheelsManucafturers, out wheelsCurrentAirPressures);

            GasType gasType;
            float fuelLeft;
            float maxFuel;
            float batteryLeft;
            float maxBatteryTime;

            bool electric = isElectric(i_VehicleType);

            // Read specific properties and insert the vehicle to the garage

            if (vehicleType == "car")
            {
                Color color;
                NumOfDoors numOfDoors;
                readCarUniqueProperties(out color, out numOfDoors);

                if (electric)
                {
                    readElectricVehicleUniqueProperties(i_VehicleType, out batteryLeft, out maxBatteryTime);
                    m_Garage.InsertElectricCar(model, i_PlateId, color, numOfDoors, batteryLeft, maxBatteryTime, wheelsManucafturers, wheelsCurrentAirPressures, customerName, customerPhone);

                }
                else
                {
                    readGasVehicleUniqueProperties(i_VehicleType, out gasType, out fuelLeft, out maxFuel);
                    m_Garage.InsertGasCar(model, i_PlateId, color, numOfDoors, gasType, fuelLeft, maxFuel, wheelsManucafturers, wheelsCurrentAirPressures, customerName, customerPhone);
                }
            }
            else if(vehicleType == "motorcycle")
            {
                LicenseType licenseType;
                int engineCapacity;
                readMotorcycleUniqueProperties(out licenseType, out engineCapacity);

                if (electric)
                {
                    readElectricVehicleUniqueProperties(i_VehicleType, out batteryLeft, out maxBatteryTime);
                    m_Garage.InsertElectricMotorcycle(model, i_PlateId, licenseType, engineCapacity, batteryLeft, maxBatteryTime, wheelsManucafturers, wheelsCurrentAirPressures, customerName, customerPhone);
                }
                else
                {
                    readGasVehicleUniqueProperties(i_VehicleType, out gasType, out fuelLeft, out maxFuel);
                    m_Garage.InsertGasMotorcycle(model, i_PlateId, licenseType, engineCapacity, gasType, fuelLeft, maxFuel, wheelsManucafturers, wheelsCurrentAirPressures, customerName, customerPhone);
                }
            }
            else if(vehicleType == "truck")
            {
                bool containsCimicals;
                float maxCargoWeight;
                readTruckUniqueProperties(out containsCimicals, out maxCargoWeight);
                readGasVehicleUniqueProperties(i_VehicleType, out gasType, out fuelLeft, out maxFuel);
                m_Garage.InsertTruck(model, i_PlateId, containsCimicals, maxCargoWeight, gasType, fuelLeft, maxFuel, wheelsManucafturers, wheelsCurrentAirPressures, customerName, customerPhone);
            }
        }

        private void readWheelsProperties(VehicleType i_VehicleType, out string[] i_Manufacturers, out float[] i_CurrentAirPressures)
        {
            byte numOfWheels = getNumOfWheels(i_VehicleType);

            i_Manufacturers = new string[numOfWheels];
            i_CurrentAirPressures = new float[numOfWheels];

            for(int i=0; i<numOfWheels; i++)
            {
                Console.WriteLine(string.Format("Enter wheel {0} manufacturer:"), i+1);
                i_Manufacturers[i] = readAndValidateStringInput();

                Console.WriteLine(string.Format("Enter wheel {0} current air pressure:"), i + 1);
                i_CurrentAirPressures[i] = readAndValidateNonNegativeNumInput();
            }
        }

        private void readCarUniqueProperties(out Color i_Color, out NumOfDoors i_NumOfDoors)
        {
            Console.WriteLine("What is the car's color? (enter a number between 1-4)" +
                       "\n1. Red" +
                       "\n2. Silver" +
                       "\n3. White" +
                       "\n4. Black");
            
            byte chosenNumber = readAndValidateMenuChoiceInput(4);
            Color color = Color.Red;

            switch (chosenNumber)
            {
                case 1:
                    color = Color.Red;
                    break;
                case 2:
                    color = Color.Silver;
                    break;
                case 3:
                    color = Color.White;
                    break;
                case 4:
                    color = Color.Black;
                    break;
            }

            i_Color = color;

            Console.WriteLine("How many doors? (enter a number between 1-4)" +
                       "\n1. Two" +
                       "\n2. Three" +
                       "\n3. Four" +
                       "\n4. Five");

            chosenNumber = readAndValidateMenuChoiceInput(4);
            NumOfDoors numOfDoors = NumOfDoors.Two;

            switch (chosenNumber)
            {
                case 1:
                    i_NumOfDoors = NumOfDoors.Two;
                    break;
                case 2:
                    i_NumOfDoors = NumOfDoors.Three;
                    break;
                case 3:
                    i_NumOfDoors = NumOfDoors.Four;
                    break;
                case 4:
                    i_NumOfDoors = NumOfDoors.Five;
                    break;
            }

            i_NumOfDoors = numOfDoors;
        }

        private void readMotorcycleUniqueProperties(out LicenseType i_LicenseType, out int i_EngineCapacity)
        {
            Console.WriteLine("What is the motorcycle's license type? (enter a number between 1-4)" +
                       "\n1. BB" +
                       "\n2. AA" +
                       "\n3. B1" +
                       "\n4. A");

            byte chosenNumber = readAndValidateMenuChoiceInput(4);
            LicenseType licenseType = LicenseType.BB;

            switch (chosenNumber)
            {
                case 1:
                    licenseType = LicenseType.BB;
                    break;
                case 2:
                    licenseType = LicenseType.AA;
                    break;
                case 3:
                    licenseType = LicenseType.B1;
                    break;
                case 4:
                    licenseType = LicenseType.A;
                    break;
            }

            i_LicenseType = licenseType;

            Console.WriteLine("What is the motorcycle's engine capacity (enter a positive integer)");

            i_EngineCapacity = (int)readAndValidateNonNegativeNumInput(true, true);
        }

        private void readTruckUniqueProperties(out bool i_ContainsCimicals, out float i_MaxCargoWeight)
        {
            Console.WriteLine("Does the truck contain cimicals? (enter a number between 1-2)" +
                       "\n1. Yes" +
                       "\n2. No");

            byte chosenNumber = readAndValidateMenuChoiceInput(2);

            i_ContainsCimicals = chosenNumber == 1;

            Console.WriteLine("What is the truck's max cargo weight (enter a non-negative number)");

            i_MaxCargoWeight = readAndValidateNonNegativeNumInput();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        private void readGasVehicleUniqueProperties(VehicleType i_VehicleType, out GasType i_GasType, out float i_FuelLeft, out float i_MaxFuel)
        {
            if(i_VehicleType == VehicleType.ElectricCar || i_VehicleType == VehicleType.ElectricMotorcycle)
            {
                throw new ArgumentException();
            }

            string vehicleType = stringifyVehicleType(i_VehicleType);

            Console.WriteLine(string.Format("What is the {0}'s gas type? (enter a number between 1-4)" +
                       "\n1. Octan98" +
                       "\n2. Octan96" +
                       "\n3. Octan95" +
                       "\n4. Soler", vehicleType));

            byte chosenNumber = readAndValidateMenuChoiceInput(4);
            GasType gasType = GasType.Octan98;

            switch (chosenNumber)
            {
                case 1:
                    gasType = GasType.Octan98;
                    break;
                case 2:
                    gasType = GasType.Octan96;
                    break;
                case 3:
                    gasType = GasType.Octan95;
                    break;
                case 4:
                    gasType = GasType.Soler;
                    break;
            }

            i_GasType = gasType;

            Console.WriteLine(string.Format("How much fuel left in the {0}'s tank? (enter a non-negative number)", vehicleType));

            i_FuelLeft = readAndValidateNonNegativeNumInput();

            Console.WriteLine(string.Format("What is the maximum possible fuel of the {0}'s tank? (enter a positive number)", vehicleType));

            i_MaxFuel = readAndValidateNonNegativeNumInput(true, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        private void readElectricVehicleUniqueProperties(VehicleType i_VehicleType, out float i_BatteryLeft, out float i_MaxBatteryTime)
        {
            if(i_VehicleType == VehicleType.Truck || i_VehicleType == VehicleType.GasCar || i_VehicleType == VehicleType.GasMotorcycle)
            {
                throw new ArgumentException();
            }

            string vehicleType = stringifyVehicleType(i_VehicleType);

            Console.WriteLine(string.Format("How much time left in the {0}'s battery? (enter a non-negative number)", vehicleType));

            i_BatteryLeft = readAndValidateNonNegativeNumInput();

            Console.WriteLine(string.Format("What is the maximum time of the {0}'s battery? (enter a non-negative number)", vehicleType));

            i_MaxBatteryTime = readAndValidateNonNegativeNumInput();
        }

        private string stringifyVehicleType(VehicleType i_VehicleType)
        {
            string vehicleType = "car";

            if (i_VehicleType == VehicleType.ElectricMotorcycle || i_VehicleType == VehicleType.GasMotorcycle)
            {
                vehicleType = "motorcycle";
            }
            else if (i_VehicleType == VehicleType.Truck)
            {
                vehicleType = "truck";
            }

            return vehicleType;
        }

        private byte getNumOfWheels(VehicleType i_VehicleType)
        {
            byte numOfWheels = 0;

            switch (i_VehicleType)
            {
                case VehicleType.ElectricCar:
                    numOfWheels = 4;
                    break;
                case VehicleType.GasCar:
                    numOfWheels = 4;
                    break;
                case VehicleType.ElectricMotorcycle:
                    numOfWheels = 2;
                    break;
                case VehicleType.GasMotorcycle:
                    numOfWheels = 2;
                    break;
                case VehicleType.Truck:
                    numOfWheels = 16;
                    break;
            }

            return numOfWheels;
        }

        private bool isElectric(VehicleType i_VehicleType)
        {
            return i_VehicleType == VehicleType.ElectricCar || i_VehicleType == VehicleType.ElectricMotorcycle;
        }

        private void showGaragePlatesId()
        {
            Console.WriteLine("Choose a vehicle status: (enter a number between 1-4)" +
                       "\n1. In progress" +
                       "\n2. Payed" +
                       "\n3. Done" +
                       "\n4. All vehicle statuses");

            byte chosenNumber = readAndValidateMenuChoiceInput(4);
            List<string> platesId = null;

            switch (chosenNumber)
            {
                case 1:
                    platesId = m_Garage.GetPlatesId(VehicleStatus.InProgress);
                    break;
                case 2:
                    platesId = m_Garage.GetPlatesId(VehicleStatus.Payed);
                    break;
                case 3:
                    platesId = m_Garage.GetPlatesId(VehicleStatus.Done);
                    break;
                case 4:
                    platesId = m_Garage.GetPlatesId();
                    break;
            }

            Console.WriteLine("Here is the plates ID list:");

            foreach(string plateId in platesId)
            {
                Console.WriteLine(plateId);
            }
        }

        private void changeVehicleState()
        {
            Console.WriteLine("Enter a plate ID:");

            string plateId = readAndValidateStringInput(true);

            Console.WriteLine("Choose a new vehicle status: (enter a number between 1-3)" +
                       "\n1. In progress" +
                       "\n2. Payed" +
                       "\n3. Done");

            byte chosenNumber = readAndValidateMenuChoiceInput(3);

            try
            {
                switch (chosenNumber)
                {
                    case 1:
                        m_Garage.ChangeVehicleState(plateId, VehicleStatus.InProgress);
                        break;
                    case 2:
                        m_Garage.ChangeVehicleState(plateId, VehicleStatus.Payed);
                        break;
                    case 3:
                        m_Garage.ChangeVehicleState(plateId, VehicleStatus.Done);
                        break;
                }

                Console.WriteLine("The vehicle state was changed successfully");
            }
            catch
            {
                Console.WriteLine("An error occured. Please try again...");
            }
        }

        private void inflateWheels()
        {
            Console.WriteLine("Enter a plate ID:");

            string plateId = readAndValidateStringInput(true);

            try
            {
                m_Garage.InflateWheels(plateId);
                Console.WriteLine("The vehicle's wheels were successfully inflated to maximum");
            }
            catch
            {
                Console.WriteLine("An error occured. Please try again...");
            }
        }

        private void refuelGasVehicle()
        {
            Console.WriteLine("Enter a plate ID:");

            string plateId = readAndValidateStringInput(true);

            Console.WriteLine("Choose a gas type: (enter a number between 1-4)" +
                       "\n1. Octan98" +
                       "\n2. Octan96" +
                       "\n3. Octan95" +
                       "\n4. Soler");

            byte chosenNumber = readAndValidateMenuChoiceInput(4);

            Console.WriteLine("How many liters? (enter a positive number)");

            float liters = readAndValidateNonNegativeNumInput(true, false);

            try
            {
                switch (chosenNumber)
                {
                    case 1:
                        m_Garage.RefuelVehicle(plateId, GasType.Octan98, liters);
                        break;
                    case 2:
                        m_Garage.RefuelVehicle(plateId, GasType.Octan96, liters);
                        break;
                    case 3:
                        m_Garage.RefuelVehicle(plateId, GasType.Octan95, liters);
                        break;
                    case 4:
                        m_Garage.RefuelVehicle(plateId, GasType.Soler, liters);
                        break;
                }

                Console.WriteLine("The vehicle has been refueled successfully");
            }
            catch(ArgumentOutOfRangeException aoore)
            {
                Console.WriteLine("Invalid amount of liters. " + aoore.StackTrace);
            }
            catch
            {
                Console.WriteLine("An error occured. Please try again...");
            }
        }

        private void chargeElectricVehicle()
        {
            Console.WriteLine("Enter a plate ID:");

            string plateId = readAndValidateStringInput(true);

            Console.WriteLine("How much time to charge? (in minutes, enter a positive number)");

            float minutesToCharge = readAndValidateNonNegativeNumInput(true, false);
            float hoursToCharge = minutesToCharge / 60;

            try
            {
                m_Garage.ChargeBattery(plateId, hoursToCharge);
            }
            catch(ArgumentException ae)
            {
                Console.WriteLine("Invalid input. Please choose an electric vehicle to charge it's battery");
            }
        }

        private void showVehicleDetails()
        {
            try
            {
                Console.WriteLine("Enter a plate ID:");
                string plateId = readAndValidateStringInput(true);

                Customer customer = m_Garage.GetCustomerByPlateId(plateId);
                Vehicle vehicle = customer.Vehicle;
                
                /*VehicleType vehicleType = customer.VehicleType;
                string vehicleTypeStr = stringifyVehicleType(vehicleType);*/

                string customerGeneralMsg = "Plate Id: {0} \nModel: {1} \nCustomer Name: {2} \nCustomer Phone: {3} \nVehicle Status: {4} \n";
                string currentWheelMsg = "Wheel Manufacture: {0}, Wheel Current Air Pressure: {1} \n";
                string wheelsDeatailsMsg = "Wheels Details: \n{0}";
                string fuelDetailsMsg = "Fuel Type: {0}, Fuel Amount: {1} \n";
                string batteryDetailsMsg = "Battery: {0} \n";

                string carUniqueDetailsMsg = "Color: {0} \nNumber of doors: {1} \n";
                string motorcycleUniqueDetailsMsg = "License type: {0} \nEngine capacity: {1} \n";
                string truckUniqueDetailsMsg = "{0} cimicals \nMaximal cargo weight: {1} \n";

                StringBuilder wheelsMsg = new StringBuilder();

                //Print General message
                Console.WriteLine(string.Format(customerGeneralMsg, vehicle.PlateID, vehicle.Model,
                    customer.CustomerName, customer.CustomerPhone, customer.VehicleStatus));

                foreach (var wheel in vehicle.Wheels)
                {
                    wheelsMsg.Append(string.Format(currentWheelMsg, wheel.Manufacturer, wheel.CurrentAirPressure));
                }

                //Prints Wheels details
                Console.WriteLine(string.Format(wheelsDeatailsMsg, wheelsMsg.ToString()));

                //In case vehicle is of type GasCar
                if (vehicle is GasCar gasCar)
                {
                    Console.WriteLine(string.Format(fuelDetailsMsg, gasCar.GasType, gasCar.FuelLeft), 
                        string.Format(carUniqueDetailsMsg, gasCar.Color, gasCar.NumOfDoors));
                }

                //In case vehicle is of type ElectricCar
                else if (vehicle is ElectricCar electricCar)
                {
                    Console.WriteLine(string.Format(batteryDetailsMsg, electricCar.EnergyLeft),
                        string.Format(carUniqueDetailsMsg, electricCar.Color, electricCar.NumOfDoors));

                }

                //In case vehicle is of type GasMotorcycle
                else if (vehicle is GasMotorcycle gasMotorcycle)
                {
                    Console.WriteLine(string.Format(fuelDetailsMsg, gasMotorcycle.GasType, gasMotorcycle.FuelLeft),
                        string.Format(motorcycleUniqueDetailsMsg, gasMotorcycle.LicenseType, gasMotorcycle.EngineCapacity));
                }

                //In case vehicle is of type ElectricMotorcycle
                else if (vehicle is ElectricMotorcycle electricMotorcycle)
                {
                    Console.WriteLine(string.Format(batteryDetailsMsg, electricMotorcycle.EnergyLeft),
                        string.Format(motorcycleUniqueDetailsMsg, electricMotorcycle.LicenseType, electricMotorcycle.EngineCapacity));

                }

                //In case vehicle is of type Truck
                else if (vehicle is Truck truck)
                {
                    string containsOrNot = "Does not contain";
                    if (truck.ContainsCimicals)
                    {
                        containsOrNot = "Contains";
                    }
                    Console.WriteLine(string.Format(fuelDetailsMsg, truck.GasType, truck.FuelLeft),
                        string.Format(truckUniqueDetailsMsg, containsOrNot, truck.MaxCargoWeight));
                }
            }
            catch
            {
                Console.WriteLine("An error occured. Please try again...");
            }
            
        }

        private void killConsoleUI()
        {
            Environment.Exit(0);
        }
    }
}
