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


        //CTOR for new garage's customer
        public Customer(string i_CustomerName, string i_CustomerPhone, Vehicle i_Vehicle)
        {
            m_CustomerName = i_CustomerName;
            m_CustomerPhone = i_CustomerPhone;
            m_Vehicle = i_Vehicle;
            m_VehicleStatus = VehicleStatus.InProgress;

        }

        //Properties to get the customer's name
        public string CustomerName
        {
            get
            {
                return this.m_CustomerName;
            }
        }

        //Properties to get the customer's phone number
        public string CustomerPhone
        {
            get
            {
                return this.m_CustomerPhone;
            }
        }

        //Properties to get / set the customer's vehicle status in the garage
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

        //Properties to get the customer's vehicle object
        public Vehicle Vevicle
        {
            get
            {
                return this.m_Vehicle;
            }
        }
    }
}
