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

        /// <summary>
        /// Constructor
        /// </summary>
        public Vehicle(string i_Model, string i_PlateID, float i_EnergyLeft)
        {
            m_Model = i_Model;
            m_PlateID = i_PlateID;
            m_EnergyLeft = i_EnergyLeft;
            m_Wheels = null;
        }

        /// <summary>
        /// Returns true if the given and this vehicle's plate IDs are identical
        /// </summary>
        /// <returns></returns>
        public bool Equals(Vehicle i_Vehicle)
        {
            return i_Vehicle.PlateID == this.m_PlateID;
        }



        /// <summary>
        /// Clears and re-Sets the vehicle's wheels with the given parameters. 
        /// Manufacturers and CurrentAirPressures arrays should be ordered in a corresponding way
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public void SetWheels(byte i_NumOfWheels, string[] i_Manufacturers, float[] i_CurrentAirPressures, float i_MaxAirPressure)
        {
            // Validate the length of the array parameters
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

                // In case both validations succeded:
                if (arraysContentValid)
                {
                    m_Wheels.Clear();

                    for (int i = 0; i < i_NumOfWheels; i++)
                    {
                        m_Wheels.Add(new Wheel(i_Manufacturers[i], i_CurrentAirPressures[i], i_MaxAirPressure));
                    }
                }
                // In case of validation failure:
                else
                {
                    //throw new ArgumentException();
                }
            }
        }

        /// <summary>
        /// Returns the vehicle's model
        /// </summary>
        public string Model
        {
            get
            {
                return m_Model;
            }
        }

        /// <summary>
        /// Returns the vehicle's plate ID
        /// </summary>
        public string PlateID
        {
            get
            {
                return m_PlateID;
            }
        }

        /// <summary>
        /// Returns the amount of energy left in the vehicle (by percentage)
        /// </summary>
        public float EnergyLeft
        {
            get
            {
                return m_EnergyLeft;
            }
        }

        /// <summary>
        /// Returns a list of the vehicle's wheels
        /// </summary>
        public List<Wheel> Wheels
        {
            get
            {
                return m_Wheels;
            }
        }

        /// <summary>
        /// Inner class of Vehicle. Represents a wheel of a vehicle
        /// </summary>
        public class Wheel
        {
            private string m_Manufacturer;
            private float m_CurrentAirPressure;
            private float m_MaxAirPressure;

            /// <summary>
            /// Constructor
            /// </summary>
            public Wheel(string i_Manufacturer, float i_CurrentAirPressure, float i_MaxAirPressure)
            {
                m_Manufacturer = i_Manufacturer;
                m_CurrentAirPressure = i_CurrentAirPressure;
                m_MaxAirPressure = i_MaxAirPressure;
            }

            /// <summary>
            /// Inflates a wheel with the given amount of air (by pressure units)
            /// </summary>
            /// <exception cref="ValueOutOfRangeException"></exception>
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

            /// <summary>
            /// Returns the maximum possible pressure in the wheel
            /// </summary>
            public float MaxAirPressure
            {
                get
                {
                    return m_MaxAirPressure;
                }
            }

            /// <summary>
            /// Returns the current air pressure in the wheel
            /// </summary>
            public float CurrentAirPressure
            {
                get
                {
                    return m_CurrentAirPressure;
                }
            }

            /// <summary>
            /// Returns the missing air pressure in the wheel
            /// </summary>
            public float MissingAirPressure
            {
                get
                {
                    return m_MaxAirPressure - m_CurrentAirPressure;
                }
            }

            /// <summary>
            /// Returns the name of the manufacturer of the wheel
            /// </summary>
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
