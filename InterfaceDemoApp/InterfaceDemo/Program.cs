using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    //Interface is a contract
    //Classes implement interfaces
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IComputerController> controllers = new List<IComputerController>();
            Keyboard keyboard = new Keyboard();
            GameController gameController = new GameController();
            BatteryPowerGameController battery = new BatteryPowerGameController();
            BatteryPoweredKeyboard batteryPoweredkboard = new BatteryPoweredKeyboard();

            controllers.Add(gameController);
            controllers.Add(keyboard);
            controllers.Add(battery);

            foreach(IComputerController item in controllers)
            {
                if(item is BatteryPowerGameController joystick)
                {
                    Console.WriteLine(joystick.BatteryLevel);
                }
            }

            using(GameController gc = new GameController())
            {

            }

            List<IBatteryPowered> powereds = new List<IBatteryPowered>();
            powereds.Add(battery);


            Console.ReadLine();
        }
    }
}
