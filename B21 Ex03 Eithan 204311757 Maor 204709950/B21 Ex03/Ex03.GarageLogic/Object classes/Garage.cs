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

        /// <summary>
        /// Constructor
        /// </summary>
        public Garage()
        {
            m_Customers = new Dictionary<string, Customer>();
        }

        /// <summary>
        /// Insert new gas car to the garage
        /// </summary>
        /// <exception cref="ArgumentException" cref="ArgumentNullException"></exception>
        /// <returns>True if a new gas car has been inserted to the garage, and false otherwise</returns>
        public bool InsertGasCar(string i_Model, string i_PlateID, Color i_Color, NumOfDoors i_NumOfDoors, GasType i_GasType,
            float i_FuelLeft, float i_MaxFuel, string[] i_WheelsManufacturers, float[] i_WheelsCurrentAirPressures, string i_CostumerName, string i_CostumerPhone)
        {
            bool operationSucceeded = false;

            if (!vehicleExists(i_PlateID))
            {
                GasCar newGasCar = new GasCar(i_Model, i_PlateID, i_Color, i_NumOfDoors, i_GasType, i_FuelLeft, i_MaxFuel, i_WheelsManufacturers, i_WheelsCurrentAirPressures);
                Customer newCustomer = new Customer(i_CostumerName, i_CostumerPhone, newGasCar);

                m_Customers.Add(i_PlateID, newCustomer);

                operationSucceeded = true;
            }
            else
            {
                // Change the existing vehicle's status to "InProgress"
                ChangeVehicleState(i_PlateID, VehicleStatus.InProgress);
            }

            return operationSucceeded;
        }

        /// <summary>
        /// Insert new electric car to the garage
        /// </summary>
        /// <exception cref="ArgumentException" cref="ArgumentNullException"></exception>
        /// <returns>True if a new electric car has been inserted to the garage, and false otherwise</returns>
        public bool InsertElectricCar(string i_Model, string i_PlateID, Color i_color, NumOfDoors i_NumOfDoors, float i_BatteryLeft, float i_MaxBateryTime, 
            string[] i_WheelsManufacturers, float[] i_WheelsCurrentAirPressures, float i_EnergyLeft, string i_CostumerName, string i_CostumerPhone)
        {
            bool operationSucceeded = false;

            if (!vehicleExists(i_PlateID))
            {
                ElectricCar newElectricCar = new ElectricCar(i_Model, i_PlateID, i_color, i_NumOfDoors, i_BatteryLeft, i_MaxBateryTime, i_WheelsManufacturers, i_WheelsCurrentAirPressures);
                Customer newCustomer = new Customer(i_CostumerName, i_CostumerPhone, newElectricCar);

                m_Customers.Add(i_PlateID, newCustomer);

                operationSucceeded = true;
            }
            else
            {
                // Change the existing vehicle's status to "InProgress"
                ChangeVehicleState(i_PlateID, VehicleStatus.InProgress);
            }

            return operationSucceeded;
        }

        /// <summary>
        /// Insert new electric motorcycle to the garage
        /// </summary>
        /// <exception cref="ArgumentException" cref="ArgumentNullException"></exception>
        /// <returns>True if a new electric motorcycle has been inserted to the garage, and false otherwise</returns>
        public bool InsertElectricMotorcycle(string i_Model, string i_PlateID, LicenseType i_LicenseType, int i_EngineCapacity,
            float i_BatteryLeft, float i_MaxBateryTime, string[] i_WheelsManufacturers, float[] i_WheelsCurrentAirPressures, string i_CostumerName, string i_CostumerPhone)
        {
            bool operationSucceeded = false;

            if (!vehicleExists(i_PlateID))
            {
                ElectricMotorcycle newElectricMotorcycle = new ElectricMotorcycle(i_Model, i_PlateID, i_LicenseType, i_EngineCapacity, i_BatteryLeft, i_MaxBateryTime, i_WheelsManufacturers, i_WheelsCurrentAirPressures);
                Customer newCustomer = new Customer(i_CostumerName, i_CostumerPhone, newElectricMotorcycle);

                m_Customers.Add(i_PlateID, newCustomer);

                operationSucceeded = true;
            }
            else
            {
                // Change the existing vehicle's status to "InProgress"
                ChangeVehicleState(i_PlateID, VehicleStatus.InProgress);
            }

            return operationSucceeded;
        }

        /// <summary>
        /// Insert new gas motorcycle to the garage
        /// </summary>
        /// <exception cref="ArgumentException" cref="ArgumentNullException"></exception>
        /// <returns>True if a new gas motorcycle has been inserted to the garage, and false otherwise</returns>
        public bool InsertGascMotorcycle(string i_Model, string i_PlateID, LicenseType i_LicenseType, int i_EngineCapacity, GasType i_GasType,
            float i_FuelLeft, float i_MaxFuel, string[] i_WheelsManufacturers, float[] i_WheelsCurrentAirPressures, string i_CostumerName, string i_CostumerPhone)
        {
            bool operationSucceeded = false;

            if (!vehicleExists(i_PlateID))
            {
                GasMotorcycle newGasMotorcycle = new GasMotorcycle(i_Model, i_PlateID, i_LicenseType, i_EngineCapacity, i_GasType, i_FuelLeft, i_MaxFuel, i_WheelsManufacturers, i_WheelsCurrentAirPressures);
                Customer newCustomer = new Customer(i_CostumerName, i_CostumerPhone, newGasMotorcycle);

                m_Customers.Add(i_PlateID, newCustomer);

                operationSucceeded = true;
            }
            else
            {
                // Change the existing vehicle's status to "InProgress"
                ChangeVehicleState(i_PlateID, VehicleStatus.InProgress);
            }

            return operationSucceeded;
        }

        /// <summary>
        /// Insert new truck to the garage
        /// </summary>
        /// <exception cref="ArgumentException" cref="ArgumentNullException"></exception>
        /// <returns>True if a new truck has been inserted to the garage, and false otherwise</returns>
        public bool InsertTruck(string i_Model, string i_PlateID, bool i_ContainsCimicals, float i_MaxCargoWeight, GasType i_GasType,
            float i_FuelLeft, float i_MaxFuel, string[] i_WheelsManufacturers, float[] i_WheelsCurrentAirPressures, string i_CostumerName, string i_CostumerPhone)
        {
            bool operationSucceeded = false;

            if (!vehicleExists(i_PlateID))
            {
                Truck newTruck = new Truck(i_Model, i_PlateID, i_ContainsCimicals, i_MaxCargoWeight, i_GasType, i_FuelLeft, i_MaxFuel, i_WheelsManufacturers, i_WheelsCurrentAirPressures);
                Customer newCustomer = new Customer(i_CostumerName, i_CostumerPhone, newTruck);

                m_Customers.Add(i_PlateID, newCustomer);

                operationSucceeded = true;
            }
            else
            {
                // Change the existing vehicle's status to "InProgress"
                ChangeVehicleState(i_PlateID, VehicleStatus.InProgress);
            }

            return operationSucceeded;
        }

        /// <summary>
        /// Check if the given plate id already exists in the garage
        /// </summary>
        /// <returns>True if exists, and false otherwise</returns>
        private bool vehicleExists(string i_PlateID)
        {
            return m_Customers.ContainsKey(i_PlateID);
        }

        /// <summary>
        /// Get all of the vehicle's plate IDs in the garage
        /// </summary>
        /// <returns>A list of all the plate IDs</returns>
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

        /// <summary>
        /// Get some (by vehicle's status) of the vehicle's plate IDs in the garage
        /// </summary>
        /// <returns>A list of the desired plate IDs</returns>
        public List<string> GetPlatesId(VehicleStatus i_VehicleStatus)
        {
            List<string> platesId = new List<string>();

            if (m_Customers.Count > 0)
            {
                foreach (var item in m_Customers)
                {
                    if(item.Value.VehicleStatus == i_VehicleStatus)
                    {
                        platesId.Add(item.Key);
                    }
                }
            }

            return platesId;
        }

        /// <summary>
        /// Change the vehicle state in the garage
        /// </summary>
        /// <exception cref="ArgumentException" cref="ArgumentNullException"></exception>
        public void ChangeVehicleState(string i_PlateId, VehicleStatus i_VehicleStatus)
        {
            if (vehicleExists(i_PlateId))
            {
                m_Customers[i_PlateId].VehicleStatus = i_VehicleStatus;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Inflate all wheels' pressure to maximum in the specified vehicle in the garage
        /// </summary>
        /// <exception cref="ArgumentException" cref="ValueOutOfRangeException"></exception>
        public void InflateWheels(string i_PlateId)
        {    
            if (vehicleExists(i_PlateId))
            {
                List<Vehicle.Wheel> m_Wheels = m_Customers[i_PlateId].Vehicle.Wheels;

                foreach (var wheel in m_Wheels)
                {
                    wheel.Inflate(wheel.MissingAirPressure);
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Get vehicle by its plate ID
        /// </summary>
        /// <returns>The vehicle object of this plate id</returns>
        /// <exception cref="ArgumentException"></exception>
        private Vehicle getVehicleByPlateId(string i_PlateId)
        {
            Vehicle vehicleToReturn = null;

            if (vehicleExists(i_PlateId))
            {
                vehicleToReturn = m_Customers[i_PlateId].Vehicle;

            }
            else
            {
                throw new ArgumentException();
            }

            return vehicleToReturn;
        }

        /// <summary>
        /// Refuel the gas tank in the specified vehicle in the garage with the given gas type and liters amount
        /// </summary>
        /// <exception cref="ArgumentException" cref="ValueOutOfRangeException"></exception>
        public void RefuelVehicle(string i_PlateId, GasType i_GasType, float i_Liters)
        {
            if (vehicleExists(i_PlateId))
            {
                Vehicle vehicle = getVehicleByPlateId(i_PlateId);

                if (vehicle is GasCar gasCarToRefuel)
                {
                    gasCarToRefuel.Refuel(i_Liters, i_GasType);
                }
                else if (vehicle is GasMotorcycle gasMotorcycleToRefuel)
                {
                    gasMotorcycleToRefuel.Refuel(i_Liters, i_GasType);
                }
                else if (vehicle is Truck truckToRefuel)
                {
                    truckToRefuel.Refuel(i_Liters, i_GasType);
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            else
            {
                throw new ArgumentException(); 
            }
        }

        /// <summary>
        /// Charges specified electric vehicle in the garage with given time (by hours)
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public void ChargeBattery(string i_PlateId, float i_Hours)
        {
            if (vehicleExists(i_PlateId))
            {
                Vehicle vehicle = getVehicleByPlateId(i_PlateId);

                if (vehicle is ElectricCar gasCarToRefuel)
                {
                    gasCarToRefuel.ChargeBattery(i_Hours);
                }
                else if (vehicle is ElectricMotorcycle gasMotorcycleToRefuel)
                {
                    gasMotorcycleToRefuel.ChargeBattery(i_Hours);
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Get customer by it's vehicle's plate ID
        /// </summary>
        /// <exception cref="ArgumentException" cref="ArgumentNullException" cref="KeyNotFoundException"></exception>
        /// <returns>The customer object corresponding to the given plate ID</returns>
        public Customer GetCustomerByPlateId(string i_PlateId)
        {
            if (vehicleExists(i_PlateId))
            {
                return m_Customers[i_PlateId];
            }
            else
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Returns the garage's (PlateID, Customer) dictionary
        /// </summary>
        public Dictionary<string, Customer> Customers
        {
            get
            {
                return m_Customers;
            }
        }
    }
}
