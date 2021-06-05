using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    interface IGasVehicle
    {
        void Refuel(float i_Liters, GasType i_GasType);
        GasType GasType { get; }
        float FuelLeft { get; }
        float MaxFuel { get; }
    }
}
