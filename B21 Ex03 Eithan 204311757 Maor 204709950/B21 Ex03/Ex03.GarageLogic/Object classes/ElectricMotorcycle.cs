using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class ElectricMotorcycle: Motorcycle, IElectricVehicle
    {
        private float m_BatteryLeft;
        private float m_MaxBatteryTime;
        private VehicleType m_vehicleType;


        public ElectricMotorcycle(string i_Model, string i_PlateID, LicenseType i_LicenseType, int i_EngineCapacity, 
            float i_BatteryLeft, float i_MaxBateryTime, string[] i_WheelsManufacturers, float[] i_WheelsCurrentAirPressures) :
            base(i_Model, i_PlateID, (i_BatteryLeft / i_MaxBateryTime) * 100, i_LicenseType, i_EngineCapacity,
                i_WheelsManufacturers, i_WheelsCurrentAirPressures)
        {
            m_BatteryLeft = i_BatteryLeft;
            m_MaxBatteryTime = i_MaxBateryTime;
            m_vehicleType = VehicleType.GasMotorcycle;
        }

        // Throws ValueOutOfRangeException
        public void ChargeBattery(float i_Hours)
        {
            if (i_Hours <= m_MaxBatteryTime - m_BatteryLeft && i_Hours >= 0)
            {
                m_BatteryLeft += i_Hours;
            }
            else
            {
                throw new ValueOutOfRangeException(0, m_MaxBatteryTime - m_BatteryLeft);
            }
        }

        public float BatteryLeft
        {
            get
            {
                return m_BatteryLeft;
            }
        }

        public float MaxBatteryTime
        {
            get
            {
                return m_MaxBatteryTime;
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
