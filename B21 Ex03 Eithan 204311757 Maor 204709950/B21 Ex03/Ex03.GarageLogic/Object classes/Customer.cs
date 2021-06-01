using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Customer
    {
        private string m_CustomerName;
        private string m_CustomerPhone;
        private VehicleStatus m_VehicleStatus;
        private Vehicle m_Vehicle;


        /// <summary>
        /// Constructor
        /// </summary>
        public Customer(string i_CustomerName, string i_CustomerPhone, Vehicle i_Vehicle)
        {
            m_CustomerName = i_CustomerName;
            m_CustomerPhone = i_CustomerPhone;
            m_Vehicle = i_Vehicle;
            m_VehicleStatus = VehicleStatus.InProgress;

        }

        /// <summary>
        /// Returns the customer's name
        /// </summary>
        public string CustomerName
        {
            get
            {
                return this.m_CustomerName;
            }
        }

        /// <summary>
        /// Returns the customer's phone number
        /// </summary>
        public string CustomerPhone
        {
            get
            {
                return this.m_CustomerPhone;
            }
        }

        /// <summary>
        /// Get / Set property for the customer's vehicle status in the garage
        /// </summary>
        public VehicleStatus VehicleStatus
        {
            get
            {
                return this.m_VehicleStatus;
            }
            set
            {
                m_VehicleStatus = value;
            }
        }

        /// <summary>
        /// Returns the customer's vehicle
        /// </summary>
        public Vehicle Vehicle
        {
            get
            {
                return this.m_Vehicle;
            }
        }
    }
}
