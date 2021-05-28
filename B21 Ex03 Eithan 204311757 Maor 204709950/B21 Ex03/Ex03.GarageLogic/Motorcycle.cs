﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Motorcycle: Vehicle
    {
        private LicenseType m_LiscenceType;
        private int m_EngineCapacity;

        public Motorcycle(string i_Model, string i_PlateID, float i_EnergyLeft, LicenseType i_LicenseType, int i_EngineCapacity):
            base(i_Model, i_PlateID, i_EnergyLeft)
        {
            m_LiscenceType = i_LicenseType;
            m_EngineCapacity = i_EngineCapacity;
        }

        public LicenseType LicenseType
        {
            get
            {
                return m_LiscenceType;
            }
        }

        public int EngineCapacity
        {
            get
            {
                return m_EngineCapacity;
            }
        }
    }

    public enum LicenseType
    {
        BB,
        AA,
        B1,
        A
    }
}
