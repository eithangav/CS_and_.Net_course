using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Motorcycle: Vehicle
    {
        private LicenseType m_LiscenceType;
        private int m_EngineCapacity;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public Motorcycle(string i_Model, string i_PlateID, float i_EnergyLeft, LicenseType i_LicenseType, int i_EngineCapacity,
            string[] i_WheelsManufacturers, float[] i_WheelsCurrentAirPressures) :
            base(i_Model, i_PlateID, i_EnergyLeft)
        {
            m_LiscenceType = i_LicenseType;
            m_EngineCapacity = i_EngineCapacity;
            SetWheels(2, i_WheelsManufacturers, i_WheelsCurrentAirPressures, 30);
        }

        /// <summary>
        /// Returns the license type of the motorcycle
        /// </summary>
        public LicenseType LicenseType
        {
            get
            {
                return m_LiscenceType;
            }
        }

        /// <summary>
        /// Returns the engine capacity of the motorcycle
        /// </summary>
        public int EngineCapacity
        {
            get
            {
                return m_EngineCapacity;
            }
        }
    }
}
