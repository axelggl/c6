namespace CSharpDiscovery.Quest04
{
    public interface IThermalCar {
        int FuelLevel { get; }

        void FillUp();
        int GetFuelLevel();
    }
    public interface IElectricCar {
        int BatteryLevel { get; }

        void Recharge();
        int GetBatteryLevel();
    }
}