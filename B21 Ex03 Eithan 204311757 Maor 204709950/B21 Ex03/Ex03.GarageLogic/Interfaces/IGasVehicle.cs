using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    interface IGasVehicle
    {
        public void Refuel(float i_Liters, GasType i_GasType);
        public GasType GasType { get; }
        public float FuelLeft { get; }
        public float MaxFuel { get; }
    }
}
