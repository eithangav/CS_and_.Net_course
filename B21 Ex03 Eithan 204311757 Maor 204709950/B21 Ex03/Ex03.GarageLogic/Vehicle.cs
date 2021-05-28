using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Vehicle
    {
        private string m_Model;
        private string m_PlateID;
        private float m_EnergyLeft;
        private List<Wheel> m_Wheels;

        public Vehicle(string i_Model, string i_PlateID, float i_EnergyLeft)
        {
            m_Model = i_Model;
            m_PlateID = i_PlateID;
            m_EnergyLeft = i_EnergyLeft;
            m_Wheels = null;
        }

        public bool Equals(Vehicle i_Vehicle)
        {
            return i_Vehicle.PlateID == this.m_PlateID;
        }

        public string Model
        {
            get
            {
                return m_Model;
            }
        }

        public string PlateID
        {
            get
            {
                return m_PlateID;
            }
        }

        public float EnergyLeft
        {
            get
            {
                return m_EnergyLeft;
            }
        }

        public List<Wheel> Wheels
        {
            get
            {
                return m_Wheels;
            }
        }

        public class Wheel
        {
            private string m_Manufacturer;
            private float m_CurrentAirPressure;
            private float m_MaxAirPressure;

            public Wheel(string i_Manufacturer, float i_CurrentAirPressure, float i_MaxAirPressure)
            {
                m_Manufacturer = i_Manufacturer;
                m_CurrentAirPressure = i_CurrentAirPressure;
                m_MaxAirPressure = i_MaxAirPressure;
            }

            public void Inflate(float i_AirToInflate)
            {
                if(i_AirToInflate <= m_MaxAirPressure - m_CurrentAirPressure)
                {
                    m_CurrentAirPressure += i_AirToInflate;
                }
                else
                {
                    //TO DO: throw ValueOutOfRangeException
                }
            }

            public float CurrentAirPressure
            {
                get
                {
                    return m_CurrentAirPressure;
                }
            }

            public float MissingAirPressure
            {
                get
                {
                    return m_MaxAirPressure - m_CurrentAirPressure;
                }
            }

            public string Manufacturer
            {
                get
                {
                    return m_Manufacturer;
                }
            }
        }
    }

    public enum VehicleType
    {
        Truck,
        GasCar,
        ElectricCar,
        GasMotorcycle,
        ElectricMotorcycle
    }

}
