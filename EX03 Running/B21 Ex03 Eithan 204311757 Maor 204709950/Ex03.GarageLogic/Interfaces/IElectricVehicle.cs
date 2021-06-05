using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    interface IElectricVehicle
    {
        void ChargeBattery(float i_Hours);
        float BatteryLeft { get; }
        float MaxBatteryTime { get; }
    }
}
