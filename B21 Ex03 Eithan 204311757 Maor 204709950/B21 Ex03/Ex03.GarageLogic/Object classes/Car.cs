using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Car: Vehicle
    {
        private Color m_Color;
        private NumOfDoors m_NumOfDoors;

        // Throws ArgumentException
        /**
      * TODO: send two arrays - wheels manufactures, wheel current air preasure
      * לשאול את המשתמש רק עבור לחץ אוויר נוכחי ויצרן
      * כנ"ל לגבי כל אחד מהרכבים רכבים, אופנועים
      */
        public Car(string i_Model, string i_PlateID, float i_EnergyLeft, Color i_Color, NumOfDoors i_NumOfDoors,
            string[] i_WheelsManufacturers, float[] i_WheelsCurrentAirPressures) :
            base(i_Model, i_PlateID, i_EnergyLeft)
        {
            m_Color = i_Color;
            m_NumOfDoors = i_NumOfDoors;
            SetWheels(4, i_WheelsManufacturers, i_WheelsCurrentAirPressures, 32);
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
}
