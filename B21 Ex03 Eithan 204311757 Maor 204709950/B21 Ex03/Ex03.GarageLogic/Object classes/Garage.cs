using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{

    //TODO:
    //1. Update diagram

    public class Garage
    {
        private Dictionary<string, Customer> m_Customers;

        //TODO: GarageUi need to clear the list every iteration
        public static List<Vehicle.Wheel> wheels = new List<Vehicle.Wheel>();

        public Garage()
        {
            m_Customers = null;
        }

 

        //Creates new Wheel
        public Vehicle.Wheel CreateWheel(string i_Manufacture, float i_CurrentPressure, float i_MaxPresxure)
        {
            Vehicle.Wheel newWheel = new Vehicle.Wheel(i_Manufacture, i_CurrentPressure, i_MaxPresxure);

            return newWheel;
        }


        //Insert new gas car to the garage
        //Throws ArgumentException
        public void InsertGasCar(string i_Model, string i_PlateID, Color i_Color, NumOfDoors i_NumOfDoors, GasType i_GasType,
            float i_FuelLeft, float i_MaxFuel, string[] i_WheelsManufacturers, float[] i_WheelsCurrentAirPressures, string i_CostumerName, string i_CostumerPhone)
        {
            GasCar newGasCar = new GasCar(i_Model, i_PlateID, i_Color, i_NumOfDoors, i_GasType, i_FuelLeft, i_MaxFuel, i_WheelsManufacturers, i_WheelsCurrentAirPressures);

            Customer newCustomer = new Customer(i_CostumerName, i_CostumerPhone, newGasCar);

            m_Customers.Add(i_PlateID, newCustomer);
        }


        //Insert new electric car to the garage
        //Throws ArgumentException
        public void InsertElectricCar(string i_Model, string i_PlateID, Color i_color, NumOfDoors i_NumOfDoors, float i_BatteryLeft, float i_MaxBateryTime, 
            string[] i_WheelsManufacturers, float[] i_WheelsCurrentAirPressures, float i_EnergyLeft, string i_CostumerName, string i_CostumerPhone)
        {
            ElectricCar newElectricCar = new ElectricCar(i_Model, i_PlateID, i_color, i_NumOfDoors, i_BatteryLeft, i_MaxBateryTime, i_WheelsManufacturers, i_WheelsCurrentAirPressures);

            Customer newCustomer = new Customer(i_CostumerName, i_CostumerPhone, newElectricCar);

            m_Customers.Add(i_PlateID, newCustomer);
        }


        //Insert new electric motorcycle to the garage
        //Throws ArgumentException
        public void InsertElectricMotorcycle(string i_Model, string i_PlateID, LicenseType i_LicenseType, int i_EngineCapacity,
            float i_BatteryLeft, float i_MaxBateryTime, string[] i_WheelsManufacturers, float[] i_WheelsCurrentAirPressures, string i_CostumerName, string i_CostumerPhone)
        {
            ElectricMotorcycle newElectricMotorcycle = new ElectricMotorcycle(i_Model, i_PlateID, i_LicenseType, i_EngineCapacity, i_BatteryLeft, i_MaxBateryTime, i_WheelsManufacturers, i_WheelsCurrentAirPressures);

            Customer newCustomer = new Customer(i_CostumerName, i_CostumerPhone, newElectricMotorcycle);

            m_Customers.Add(i_PlateID, newCustomer);
        }


        //Insert new gas motorcycle to the garage
        //Throws ArgumentException
        public void InsertGascMotorcycle(string i_Model, string i_PlateID, LicenseType i_LicenseType, int i_EngineCapacity, GasType i_GasType,
            float i_FuelLeft, float i_MaxFuel, string[] i_WheelsManufacturers, float[] i_WheelsCurrentAirPressures, string i_CostumerName, string i_CostumerPhone)
        {
            GasMotorcycle newGasMotorcycle = new GasMotorcycle(i_Model, i_PlateID, i_LicenseType, i_EngineCapacity, i_GasType, i_FuelLeft, i_MaxFuel, i_WheelsManufacturers, i_WheelsCurrentAirPressures);

            Customer newCustomer = new Customer(i_CostumerName, i_CostumerPhone, newGasMotorcycle);

            m_Customers.Add(i_PlateID, newCustomer);
        }



        //Insert new truck to the garage
        //Throws ArgumentException
        public void InsertTruck(string i_Model, string i_PlateID, bool i_ContainsCimicals, float i_MaxCargoWeight, GasType i_GasType,
            float i_FuelLeft, float i_MaxFuel, string[] i_WheelsManufacturers, float[] i_WheelsCurrentAirPressures, string i_CostumerName, string i_CostumerPhone)
        {
            Truck newTruck = new Truck(i_Model, i_PlateID, i_ContainsCimicals, i_MaxCargoWeight, i_GasType, i_FuelLeft, i_MaxFuel, i_WheelsManufacturers, i_WheelsCurrentAirPressures);

            Customer newCustomer = new Customer(i_CostumerName, i_CostumerPhone, newTruck);

            m_Customers.Add(i_PlateID, newCustomer);
        }

        //end of TODO: update Diagram


        //Return a list of all the plateIds of the vehicles in the garage
        public List<string> GetPlatesId()
        {
            List<string> platesId = new List<string>();

            if(m_Customers.Count > 0)
            {
                foreach (var item in m_Customers)
                {
                    platesId.Add(item.Key);
                }
            }
 
            return platesId;
        }


        //Change the vehicle state in the garage
        //Throws ArgumentNullException and ArgumentException/FormatException?
        public void CangeVehicleState(string i_PlateId, VehicleStatus i_vehicleStatus)
        {
            if (m_Customers.ContainsKey(i_PlateId))
            {
                m_Customers[i_PlateId].VehicleStatus = i_vehicleStatus;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }


        //Inflate wheel pressure in the specified vehicle in the garage
        //Throws ArgumentNullException and ArgumentException/FormatException?
        public void InflateWheels(string i_PlateId)
        {    
            if (m_Customers.ContainsKey(i_PlateId))
            {
                List<Vehicle.Wheel> m_Wheels = m_Customers[i_PlateId].Vehicle.Wheels;

                foreach (var wheel in m_Wheels)
                {
                    wheel.Inflate(wheel.MissingAirPressure);
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }


        //return the vehicle object of this plate id
        //Throw ArgumentNullException if there is'nt a matching vehicle in the garage
        public Vehicle getVehicleInGarage(string i_PlateId)
        {
            Vehicle m_VehicleToReturn = null;

            if (m_Customers.ContainsKey(i_PlateId))
            {
                m_VehicleToReturn = m_Customers[i_PlateId].Vehicle;

            }
            else
            {
                throw new ArgumentNullException();
            }

            return m_VehicleToReturn;
        }



        //Refuel gas tank in the specified vehicle in the garage
        //Throws ArgumentNullException, ArgumentException and FormatException?

        //TODO: Update method name in the Diagram
        public void RefuelVehicle(string i_PlateId, GasType i_GasType, float i_Liters)
        {
            if (m_Customers.ContainsKey(i_PlateId))
            {

                if (m_Customers[i_PlateId].Vehicle is GasCar m_GasCarToRefuel)
                {
                    m_GasCarToRefuel.Refuel(i_Liters, i_GasType);
                }
                else if (m_Customers[i_PlateId].Vehicle is GasMotorcycle m_GasMotorcycleToRefuel)
                {
                    m_GasMotorcycleToRefuel.Refuel(i_Liters, i_GasType);
                }
                else if (m_Customers[i_PlateId].Vehicle is Truck m_TruckToRefuel)
                {
                    m_TruckToRefuel.Refuel(i_Liters, i_GasType);
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            else
            {
                throw new ArgumentNullException(); 
            }
            
        }


        //Charges specified Electric vehicle in the garage
        //Throws ArgumentNullException, ArgumentException and FormatException
        public void ChargeBattery(string i_PlateId, float i_Hours)
        {
            if (m_Customers.ContainsKey(i_PlateId))
            {
                if (m_Customers[i_PlateId].Vehicle is ElectricCar m_GasCarToRefuel)
                {
                    m_GasCarToRefuel.ChargeBattery(i_Hours);
                }
                else if (m_Customers[i_PlateId].Vehicle is ElectricMotorcycle m_GasMotorcycleToRefuel)
                {
                    m_GasMotorcycleToRefuel.ChargeBattery(i_Hours);
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }


        //Retuens the specified vehicle - GarageUi will iterate over
        //the returned vehicle and print its details.
        //Throws ArgumentNullException, ArgumentException and FormatException
        public Vehicle GetVehicleDetels(string i_PlateId)
        {
            if (m_Customers.ContainsKey(i_PlateId))
            {
                return m_Customers[i_PlateId].Vehicle;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public Dictionary<string, Customer> Customers
        {
            get
            {
                return m_Customers;
            }
        }
    }
}
