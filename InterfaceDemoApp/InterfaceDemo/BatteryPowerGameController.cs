namespace InterfaceDemo
{
    public class BatteryPowerGameController:GameController, IBatteryPowered
    {
        public int BatteryLevel { get; set; }

    }
}
