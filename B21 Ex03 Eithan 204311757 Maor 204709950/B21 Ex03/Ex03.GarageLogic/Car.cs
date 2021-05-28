using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Car: Vehicle
    {
        private Color m_Color;
        private NumOfDoors m_NumOfDoors;

        public Car(string i_Model, string i_PlateID, float i_EnergyLeft, Color i_Color, NumOfDoors i_NumOfDoors):
            base(i_Model, i_PlateID, i_EnergyLeft)
        {
            m_Color = i_Color;
            m_NumOfDoors = i_NumOfDoors;
        }

        public Color Color
        {
            get
            {
                return m_Color;
            }
        }

        public NumOfDoors NumOfDoors
        {
            get
            {
                return m_NumOfDoors;
            }
        }
    }

    public enum NumOfDoors
    {
        Two,
        Three,
        Four,
        Five
    }

    public enum Color
    {
        Red,
        Silver,
        White,
        Black
    }
}
