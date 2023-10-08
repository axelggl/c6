using System;

namespace CSharpDiscovery.Quest04
{
    public class HybridCar : Car, IElectricCar, IThermalCar
    {
        public int FuelLevel { get; set; } = 100;
        public int BatteryLevel { get; set; } = 100;

        public HybridCar() : base()
        {

        }

        public HybridCar(string Model, string Brand, string Color, int CurrentSpeed = 0) : base(Model, Brand, Color, CurrentSpeed)
        {
            
        }

        public void FillUp()
        {
            FuelLevel = 100;
        }

        public int GetFuelLevel()
        {
            return FuelLevel;
        }

        public void Recharge()
        {
            BatteryLevel = 100;
        }

        public int GetBatteryLevel()
        {
            return BatteryLevel;
        }

        public override string ToString()
        {
            return base.ToString() + $", Battery: {BatteryLevel}%, Fuel: {FuelLevel}%";
        }
    }
}
