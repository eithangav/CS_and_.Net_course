using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class GasCar: Car, IGasVehicle
    {
        private GasType m_GasType;
        private float m_FuelLeft;
        private float m_MaxFuel;

        public GasCar(string i_Model, string i_PlateID, Color i_Color, NumOfDoors i_NumOfDoors, GasType i_GasType, float i_FuelLeft, float i_MaxFuel) :
            base(i_Model, i_PlateID, (i_FuelLeft / i_MaxFuel) * 100, i_Color, i_NumOfDoors)
        {
            m_GasType = i_GasType;
            m_FuelLeft = i_FuelLeft;
            m_MaxFuel = i_MaxFuel;
        }

        // Throws ArgumentException and ValueOutOfRangeException
        public void Refuel(float i_Liters, GasType i_GasType)
        {
            if (i_GasType == m_GasType && i_Liters <= m_MaxFuel - m_FuelLeft && i_Liters >= 0)
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
    }
}