using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Truck: Vehicle, IGasVehicle
    {
        private bool m_ContainsCimicals;
        private float m_MaxCargoWeight;

        public void Refuel(byte i_Liters, GasType i_GasType)
        {

        }

        public GasType GasType { get; }

        public float EnergyLeft { get; }

        public float MaxEnergy { get; }
    }
}
