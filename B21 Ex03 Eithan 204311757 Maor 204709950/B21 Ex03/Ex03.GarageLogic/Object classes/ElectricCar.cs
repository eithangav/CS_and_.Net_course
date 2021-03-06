using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class ElectricCar: Car, IElectricVehicle
    {
        private float m_BatteryLeft;
        private float m_MaxBatteryTime;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public ElectricCar(string i_Model, string i_PlateID, Color i_Color, NumOfDoors i_NumOfDoors, float i_BatteryLeft, float i_MaxBateryTime,
            string[] i_WheelsManufacturers, float[] i_WheelsCurrentAirPressures) :
            base(i_Model, i_PlateID, (i_BatteryLeft / i_MaxBateryTime) * 100, i_Color, i_NumOfDoors, 
                i_WheelsManufacturers, i_WheelsCurrentAirPressures)
        {
            m_BatteryLeft = i_BatteryLeft;
            m_MaxBatteryTime = i_MaxBateryTime;
        }

        /// <summary>
        /// Charges the battery with the given time (by hours)
        /// </summary>
        /// <exception cref="ValueOutOfRangeException"></exception>
        public void ChargeBattery(float i_Hours)
        {
            if(i_Hours <= m_MaxBatteryTime - m_BatteryLeft && i_Hours >= 0)
            {
                m_BatteryLeft += i_Hours;
            }
            else
            {
                throw new ValueOutOfRangeException(0, m_MaxBatteryTime - m_BatteryLeft);
            }
        }

        /// <summary>
        /// Returns the time left in the battery (by hours)
        /// </summary>
        public float BatteryLeft
        {
            get
            {
                return m_BatteryLeft;
            }
        }

        /// <summary>
        /// Returns the maximum time capacity of the battery (by hours)
        /// </summary>
        public float MaxBatteryTime
        {
            get
            {
                return m_MaxBatteryTime;
            }
        }
    }
}
