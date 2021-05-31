using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class ElectricCar: Car, IElectricVehicle
    {
        private float m_BatteryLeft;
        private float m_MaxBatteryTime;

        public ElectricCar(string i_Model, string i_PlateID, Color i_Color, NumOfDoors i_NumOfDoors, float i_BatteryLeft, float i_MaxBateryTime,
            string[] i_WheelsManufacturers, float[] i_WheelsCurrentAirPressures) :
            base(i_Model, i_PlateID, (i_BatteryLeft / i_MaxBateryTime) * 100, i_Color, i_NumOfDoors, 
                i_WheelsManufacturers, i_WheelsCurrentAirPressures)
        {
            m_BatteryLeft = i_BatteryLeft;
            m_MaxBatteryTime = i_MaxBateryTime;
        }

        // Throws ValueOutOfRangeException
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
    }
}
