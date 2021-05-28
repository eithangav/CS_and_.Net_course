using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Garage
    {
        private Dictionary<string, Customer> m_Customers;

        public Garage()
        {
            m_Customers = null;
        }
    }

    public enum VehicleStatus
    {
        InProgress,
        Done,
        Payed
    }
}
