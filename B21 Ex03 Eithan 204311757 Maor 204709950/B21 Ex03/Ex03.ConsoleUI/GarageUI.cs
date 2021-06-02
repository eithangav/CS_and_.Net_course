using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    /**
     * TODO: send two arrays - wheels manufactures, wheel current air preasure
     * 
     * אבא - כתבתי את כל המתודות חוץ מסעיף 1 "להכניס רכב חדש" - צריך לבנות לכל סוג רכב לדעתי ולהשתמש במצודות של הגראג'
     * 
     * תעבור על המתודות שכתבתי תגיד אם יש לך הערות
     * 
     * גראג' מוכן מבחינתי
     * 
     * Eithan Eithan Melech Ha'olam!
     */

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
                Console.Clear();
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
                    inflateWheels();
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
                inputStr = Console.ReadLine();

                if(inputStr == "")
                {
                    Console.WriteLine("Invalid input. Please enter a non-empty string");
                }
                else if(i_CheckPlateIdExistant && !m_Garage.VehicleExists(inputStr))
                {
                    Console.WriteLine("Plate ID doesn't exist. Please try again");
                    inputStr = "";
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
                    vehicleInsertionMenu();
                    Console.WriteLine("The vehicle was inserted successfully");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("An error occured. Please try again....");
            }
        }

        private void vehicleInsertionMenu()
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
                    insertVehicleByType(VehicleType.GasCar);
                    break;
                case 2:
                    insertVehicleByType(VehicleType.ElectricCar);
                    break;
                case 3:
                    insertVehicleByType(VehicleType.GasMotorcycle);
                    break;
                case 4:
                    insertVehicleByType(VehicleType.ElectricMotorcycle);
                    break;
                case 5:
                    insertVehicleByType(VehicleType.Truck);
                    break;
            }
        }

        private void insertVehicleByType(VehicleType i_VehicleType)
        {
            string vehicleType = stringifyVehicleType(i_VehicleType);

            // Read shared properties:

            Console.WriteLine("Enter customer's name:");
            string customerName = readAndValidateStringInput();

            Console.WriteLine("Enter customer's phone:");
            string customerPhone = readAndValidateStringInput();

            Console.WriteLine(string.Format("Enter the {0}'s model:", vehicleType));
            string model = readAndValidateStringInput();

            Console.WriteLine(string.Format("Enter the {0}'s plate ID:", vehicleType));
            string plateId = readAndValidateStringInput();

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
                    m_Garage.InsertElectricCar(model, plateId, color, numOfDoors, batteryLeft, maxBatteryTime, wheelsManucafturers, wheelsCurrentAirPressures, customerName, customerPhone);

                }
                else
                {
                    readGasVehicleUniqueProperties(i_VehicleType, out gasType, out fuelLeft, out maxFuel);
                    m_Garage.InsertGasCar(model, plateId, color, numOfDoors, gasType, fuelLeft, maxFuel, wheelsManucafturers, wheelsCurrentAirPressures, customerName, customerPhone);
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
                    m_Garage.InsertElectricMotorcycle(model, plateId, licenseType, engineCapacity, batteryLeft, maxBatteryTime, wheelsManucafturers, wheelsCurrentAirPressures, customerName, customerPhone);
                }
                else
                {
                    readGasVehicleUniqueProperties(i_VehicleType, out gasType, out fuelLeft, out maxFuel);
                    m_Garage.InsertGasMotorcycle(model, plateId, licenseType, engineCapacity, gasType, fuelLeft, maxFuel, wheelsManucafturers, wheelsCurrentAirPressures, customerName, customerPhone);
                }
            }
            else if(vehicleType == "truck")
            {
                bool containsCimicals;
                float maxCargoWeight;
                readTruckUniqueProperties(out containsCimicals, out maxCargoWeight);
                readGasVehicleUniqueProperties(i_VehicleType, out gasType, out fuelLeft, out maxFuel);
                m_Garage.InsertTruck(model, plateId, containsCimicals, maxCargoWeight, gasType, fuelLeft, maxFuel, wheelsManucafturers, wheelsCurrentAirPressures, customerName, customerPhone);
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
            // TODO: implement
        }

        private void showVehicleDetails()
        {
            // TODO: implement
        }

        private void killConsoleUI()
        {
            // TODO: implement ending the program
        }

        //Prints all the vehicles's plate id in the garage by filtered by Vehicle status.
        //If the user didnt choose vehicle status - return all the plates id in the garage
        private void getGarageVehicles(VehicleStatus i_VehicleStatus = VehicleStatus.AllCars)
        {
            StringBuilder platedIdToReturn = new StringBuilder();

            string platedIdWithVehicleStatusMsg = "List of all the garag's vehicles plates Id with Vehicle Status: {0}";
            string allGaragePlatedIdMsg = "List of all the garag's vehicles plates Id:";
            string invalidVehicleStautsMsg = "Invalid vehicle status. Please choose vehicle status: {1}, {2}, {3}";
            
            try
            {
                foreach (var costumer in m_Garage.Customers)
                {
                    if (costumer.Value.VehicleStatus == i_VehicleStatus)
                    {
                        platedIdToReturn.Append(costumer.Key);
                        platedIdToReturn.Append(", ");
                    }
                }

                //If user choosed to filter using Vehicle Status
                if (i_VehicleStatus != VehicleStatus.AllCars)
                {
                    Console.WriteLine(string.Format(platedIdWithVehicleStatusMsg, i_VehicleStatus));
                    Console.WriteLine(platedIdToReturn.ToString());

                }
                //If user didn't choose to filter using Vehicle Status
                else
                {
                    Console.WriteLine(allGaragePlatedIdMsg);
                    Console.WriteLine(platedIdToReturn.ToString());
                }

            }

            catch(ArgumentException e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(string.Format(invalidVehicleStautsMsg, VehicleStatus.InProgress, VehicleStatus.Done, VehicleStatus.Payed));
            } 

            catch(FormatException e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(string.Format(invalidVehicleStautsMsg, VehicleStatus.InProgress, VehicleStatus.Done, VehicleStatus.Payed));
            }
        }


        //Changes the desired vehicle status
        private void changeVehicleStatus(string i_PlateId, VehicleStatus i_vehicleStatus)
        {
            string plateIdDontExist = "No vehicle with plate id: {0} found";
            string invalidVehicleStautsMsg = "Invalid vehicle status. Please choose vehicle status: {1}, {2}, {3}";
           
            try
            {
                m_Garage.ChangeVehicleState(i_PlateId, i_vehicleStatus);
            }

            //In case no plate id found
            catch(ArgumentNullException e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(plateIdDontExist, i_PlateId);
            }

            //In case vehicle status is invalid
            catch(ArgumentException e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(string.Format(invalidVehicleStautsMsg, VehicleStatus.InProgress, VehicleStatus.Done, VehicleStatus.Payed));
            }
        }


        //Inflates all the vehicle's wheels to Maximum
        private void inflateAllWheels(string i_PlateId)
        {
            string plateIdDontExist = "No vehicle with plate id: {0} found";
            string inflateSucceeded = "All the wheels of vehicle with plate id: {0} were fuled to Max: {1} PSI";

            try
            {
                Vehicle m_VehicleToInflate = m_Garage.getVehicleInGarage(i_PlateId);

                foreach(var wheel in m_VehicleToInflate.Wheels)
                {
                    wheel.InflateToMax();
                }

                Console.WriteLine(string.Format(inflateSucceeded, i_PlateId, m_VehicleToInflate.Wheels[0].MaxAirPressure));
            }

            //In case there is'nt a matching vehicle in the garage
            catch(ArgumentNullException e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(plateIdDontExist, i_PlateId);
            }
        }

        private void getFullDetail(string i_PlateId)
        {
            string plateIdDontExist = "No vehicle with plate id: {0} found";

            string customerGeneralMsg = "Plate Id: {0} \n Model: {1} \n Customer Name: {2} \n Customer Phone: {3} \n Vehicle Status: {4} \n";
            
            string currentWheelMsg = "Wheel Manufacture: {0}, Wheel Current Air Pressure: {1} \n";
            string wheelsDeatailsMsg = "Wheels Details: {0} \n";

            string fuelDetailsMsg = "Fuel Type: {0}, Fuel Amount: {1} \n";
            
            string batteryDetailsMsg = "Battery: {0} \n";

            //TODO: handle types of vehicles extra messages


            StringBuilder wheelsMsg = new StringBuilder();

            try
            {
                Vehicle m_vehicleDetails = m_Garage.getVehicleInGarage(i_PlateId);
                Customer m_Customer = m_Garage.Customers[i_PlateId];

                //Prints General message
                Console.WriteLine(string.Format(customerGeneralMsg, m_vehicleDetails.PlateID, m_vehicleDetails.Model, 
                    m_Customer.CustomerName, m_Customer.CustomerPhone, m_Customer.VehicleStatus));

                foreach(var wheel in m_vehicleDetails.Wheels)
                {
                    wheelsMsg.Append(string.Format(currentWheelMsg, wheel.Manufacturer, wheel.CurrentAirPressure));
                }

                //Prints Wheels details
                Console.WriteLine(string.Format(wheelsDeatailsMsg, wheelsMsg.ToString()));

                ///////END OF GENERAL VEHICLE MESSAGES//////

                //In case vehicle is of type GasCar
                if(m_vehicleDetails is GasCar m_GasCarDetails)
                {
                    Console.WriteLine(string.Format(fuelDetailsMsg, m_GasCarDetails.GasType, m_GasCarDetails.FuelLeft));
                }

                //In case vehicle is of type ElectricCar
                else if (m_vehicleDetails is ElectricCar m_ElectricCarDetails)
                {
                    Console.WriteLine(string.Format(batteryDetailsMsg, m_ElectricCarDetails.EnergyLeft));

                }

                //In case vehicle is of type GasMotorcycle
                else if (m_vehicleDetails is GasMotorcycle m_GasMotorcycleDetails)
                {
                    Console.WriteLine(string.Format(fuelDetailsMsg, m_GasMotorcycleDetails.GasType, m_GasMotorcycleDetails.FuelLeft));
                }

                //In case vehicle is of type ElectricMotorcycle
                else if (m_vehicleDetails is ElectricMotorcycle m_ElectricMotorcycleDetails)
                {
                    Console.WriteLine(string.Format(batteryDetailsMsg, m_ElectricMotorcycleDetails.EnergyLeft));

                }

                //In case vehicle is of type Truck
                else if (m_vehicleDetails is Truck m_TruckDetails)
                {
                    Console.WriteLine(string.Format(fuelDetailsMsg, m_TruckDetails.GasType, m_TruckDetails.FuelLeft));
                }

                //TODO: handle types of vehicles extra messages

            }

            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(plateIdDontExist, i_PlateId);
            }
        }
    }
}
