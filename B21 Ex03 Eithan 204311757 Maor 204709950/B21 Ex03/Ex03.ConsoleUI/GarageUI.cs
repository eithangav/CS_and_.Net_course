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
        }

        private void printWelcomeMsg()
        {
            Console.WriteLine("Welcome to the Garage!");
        }

        private byte MainMenu()
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

        private byte parseAndValidateMenuInput(string i_Input, byte i_MaxValue)
        {


            return 1;
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
                m_Garage.CangeVehicleState(i_PlateId, i_vehicleStatus);
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
