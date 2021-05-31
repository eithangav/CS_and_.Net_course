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



        // Throws ArgumentException
        public void SetWheels(byte i_NumOfWheels, string[] i_Manufacturers, float[] i_CurrentAirPressures, float i_MaxAirPressure)
        {
            bool arraysLengthValid = i_NumOfWheels == i_Manufacturers.Length && i_NumOfWheels == i_CurrentAirPressures.Length;
            bool arraysContentValid = true;

            if (arraysLengthValid)
            {
                // Validate arrays' content
                for (int i = 0; i < i_NumOfWheels; i++)
                {
                    if (i_CurrentAirPressures[i] < 0 || i_CurrentAirPressures[i] > i_MaxAirPressure || i_Manufacturers[i] == "")
                    {
                        arraysContentValid = false;
                        break;
                    }
                }

                if (arraysContentValid)
                {
                    m_Wheels.Clear();

                    for (int i = 0; i < i_NumOfWheels; i++)
                    {
                        m_Wheels.Add(new Wheel(i_Manufacturers[i], i_CurrentAirPressures[i], i_MaxAirPressure));
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
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

            // Throws ValueOutOfRangeException
            public void Inflate(float i_AirToInflate)
            {
                if(i_AirToInflate <= m_MaxAirPressure - m_CurrentAirPressure && i_AirToInflate >= 0)
                {
                    m_CurrentAirPressure += i_AirToInflate;
                }
                else
                {
                    throw new ValueOutOfRangeException(0, m_MaxAirPressure - m_CurrentAirPressure);
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
}
