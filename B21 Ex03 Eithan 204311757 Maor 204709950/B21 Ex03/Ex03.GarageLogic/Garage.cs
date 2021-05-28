using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Garage
    {
        private Dictionary<string, Customer> m_Customers;

        //TODO: GarageUi need to clear the list every iteration
        public static List<Vehicle.Wheel> wheels = new List<Vehicle.Wheel>(); 
        

        public Garage()
        {
            m_Customers = null;
        }

        //TODO:
        //1. Update diagram
        //2. COnstructors of all vehicles types
        
        //Creates a new Customer
        private Customer createNewCusromer(string i_CostumerName, string i_CostumerPhone, Vehicle i_Vehicle)
        {
            Customer newCustomer = new Customer(i_CostumerName, i_CostumerPhone, i_Vehicle);
            return newCustomer;
        } 

        //Creates new Wheel
        public Vehicle.Wheel CreateWheel(string i_Manufacture, float i_CurrentPressure, float i_MaxPresxure)
        {
            Vehicle.Wheel newWheel = new Vehicle.Wheel(i_Manufacture, i_CurrentPressure, i_MaxPresxure);
            return newWheel; 
        }


        //Insert new gas car to the garage
        public void InsertGasCar(string i_CostumerName, string i_CostumerPhone, string i_Model, 
            string i_PlateID, float i_EnergyLeft, List<Vehicle.Wheel> i_wheels, Color i_color, 
            NumOfDoors i_NumOfDoors)
        {
            GasCar newGasCar = new GasCar(i_Model, i_PlateID, i_EnergyLeft, i_wheels, i_color, i_NumOfDoors);
           
            Customer newCustomer = new Customer(i_CostumerName, i_CostumerPhone, newGasCar);
            
            m_Customers.Add(i_PlateID, newCustomer);
        }


        //Insert new electric car to the garage
        public void InsertElectricCar(string i_CostumerName, string i_CostumerPhone, string i_Model,
            string i_PlateID, float i_EnergyLeft, List<Vehicle.Wheel> i_wheels, Color i_color,
            NumOfDoors i_NumOfDoors)
        {
            GasCar newElectricCar = new ElectricCar(i_Model, i_PlateID, i_EnergyLeft, i_wheels, i_color, i_NumOfDoors);

            Customer newCustomer = new Customer(i_CostumerName, i_CostumerPhone, newElectricCar);

            m_Customers.Add(i_PlateID, newCustomer);
        }


        //Insert new electric motorcycle to the garage
        public void InsertElectricMotorcycle(string i_CostumerName, string i_CostumerPhone, string i_Model,
            string i_PlateID, float i_EnergyLeft, List<Vehicle.Wheel> i_wheels, LicenseType i_LicenseType,
            int i_EngineCapacity)
        {
            ElectricMotorcycle newElectricMotorcycle = new ElectricMotorcycle(i_Model, i_PlateID, i_EnergyLeft, i_wheels, i_LicenseType, i_EngineCapacity);

            Customer newCustomer = new Customer(i_CostumerName, i_CostumerPhone, newElectricMotorcycle);

            m_Customers.Add(i_PlateID, newCustomer);
        }



        //Insert new gas motorcycle to the garage
        public void InsertGascMotorcycle(string i_CostumerName, string i_CostumerPhone, string i_Model,
            string i_PlateID, float i_EnergyLeft, List<Vehicle.Wheel> i_wheels, LicenseType i_LicenseType,
            int i_EngineCapacity)
        {
            GasMotorcycle newGasMotorcycle = new GasMotorcycle(i_Model, i_PlateID, i_EnergyLeft, i_wheels, i_LicenseType, i_EngineCapacity);

            Customer newCustomer = new Customer(i_CostumerName, i_CostumerPhone, newGasMotorcycle);

            m_Customers.Add(i_PlateID, newCustomer);
        }



        //Insert new truck to the garage
        public void InsertTruck(string i_CostumerName, string i_CostumerPhone, string i_Model,
            string i_PlateID, float i_EnergyLeft, List<Vehicle.Wheel> i_wheels, bool i_ContainCimicals, float i_MaxCargoWeight)
        {
            Truck newTruck = new Truck(i_Model, i_PlateID, i_EnergyLeft, i_EnergyLeft, i_wheels, i_ContainCimicals, i_MaxCargoWeight);

            Customer newCustomer = new Customer(i_CostumerName, i_CostumerPhone, newTruck);

            m_Customers.Add(i_PlateID, newCustomer);

        }
        //end of TODO: update Diagram


        //Return a list of all the plateIds of the vehicles in the garage
        public List<string> GetPlatesId()
        {
            List<string> platesId = new List<string>();
            
            foreach(var item in m_Customers)
            {
                platesId.Add(item.Key);
            }

            return platesId;
        }


        //Change the vehicle state in the garage
        public void CangeVehicleState(string i_PlateId, VehicleStatus i_vehicleStatus)
        {
            try
            {
                if (m_Customers.ContainsKey(i_PlateId))
                {
                    m_Customers[i_PlateId].VehicleStatus = i_vehicleStatus;
                }
            }

            catch(KeyNotFoundException e)
            {
                Console.WriteLine(e.StackTrace.ToString());

                throw new KeyNotFoundException(string.Format("key plateId {0} not found", i_PlateId));
            }
        }


        //Inflate wheel pressure in the specified vehicle in the garage
        public void InflateWheels(string i_PlateId) 
        {
            try
            {
                if (m_Customers.ContainsKey(i_PlateId))
                {
                    List<Vehicle.Wheel> m_Wheels =  m_Customers[i_PlateId].Vevicle.Wheels;

                    foreach(var wheel in m_Wheels)
                    {
                        wheel.Inflate(wheel.MissingAirPressure);
                    }
                }
            }
            catch(KeyNotFoundException e)
            {
                Console.WriteLine(e.StackTrace.ToString());

                throw new KeyNotFoundException(string.Format("key plateId {0} not found", i_PlateId));

            }
        }


        //Refuel gas tank in the specified vehicle in the garage
        public void Refuel(string i_PlateId, GasType i_GasType, float i_Liters)
        {
            try
            {
                if (m_Customers.ContainsKey(i_PlateId))
                {
                    m_Customers[i_PlateId].Vevicle;

                }
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.StackTrace.ToString());

                throw new KeyNotFoundException(string.Format("key plateId {0} not found", i_PlateId));

            }
        }
    }




    public enum VehicleStatus
    {
        InProgress,
        Done,
        Payed
    }


}
