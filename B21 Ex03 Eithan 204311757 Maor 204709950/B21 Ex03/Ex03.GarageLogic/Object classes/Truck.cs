using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Truck: Vehicle, IGasVehicle
    {
        private bool m_ContainsCimicals;
        private float m_MaxCargoWeight;

        private GasType m_GasType;
        private float m_FuelLeft;
        private float m_MaxFuel;
        private VehicleType m_vehicleType;


        // Throws ArgumentException
        public Truck(string i_Model, string i_PlateID, bool i_ContainsCimicals, float i_MaxCargoWeight, GasType i_GasType, 
            float i_FuelLeft, float i_MaxFuel, string[] i_WheelsManufacturers, float[] i_WheelsCurrentAirPressures) : 
            base(i_Model, i_PlateID, (i_FuelLeft/i_MaxFuel)*100)
        {
            m_ContainsCimicals = i_ContainsCimicals;
            m_MaxCargoWeight = i_MaxCargoWeight;
            m_FuelLeft = i_FuelLeft;
            m_MaxFuel = i_MaxFuel;
            m_GasType = i_GasType;
            m_vehicleType = VehicleType.Truck;
            SetWheels(16, i_WheelsManufacturers, i_WheelsCurrentAirPressures, 26);
        }

        // Throws ArgumentException and ValueOutOfRangeException
        public void Refuel(float i_Liters, GasType i_GasType)
        {
            if(i_GasType == m_GasType && i_Liters <= m_MaxFuel - m_FuelLeft && i_Liters >= 0)
            {
                m_FuelLeft += i_Liters;
            }
            else if (i_GasType != m_GasType)
            {
                throw new ArgumentException();
            }
            else
            {
                throw new ValueOutOfRangeException(0, m_MaxFuel - m_FuelLeft);
            }
        }

        public bool ContainsCimicals
        {
            get
            {
                return m_ContainsCimicals;
            }
        }

        public float MaxCargoWeight
        {
            get
            {
                return m_MaxCargoWeight;
            }
        }

        public GasType GasType
        {
            get
            {
                return m_GasType;
            }
        }

        public float FuelLeft
        {
            get
            {
                return m_FuelLeft;
            }
        }

        public float MaxFuel
        {
            get
            {
                return m_MaxFuel;
            }
        }

        public VehicleType VehicleType
        {
            get
            {
                return m_vehicleType;
            }
        }
    }
}
