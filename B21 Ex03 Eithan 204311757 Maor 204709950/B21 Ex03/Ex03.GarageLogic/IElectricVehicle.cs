using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    interface IElectricVehicle
    {
        public void ChargeBattery(byte i_Hours);
        public float BatteryLeft { get; }
        public float MaxBatteryTime { get; }
    }
}
