using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    interface IGasVehicle
    {
        public void Refuel(byte i_Liters, GasType i_GasType);
        public GasType GasType { get; }
        public float EnergyLeft { get; }
        public float MaxEnergy { get; }
    }

    public enum GasType
    {
        Octan98,
        Octan96,
        Octan95,
        Soler
    }
}
