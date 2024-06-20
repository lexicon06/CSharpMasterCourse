using System;
using System.Linq;
using System.Threading.Tasks;
using Windows.Devices.Bluetooth;
using Windows.Devices.Enumeration;

namespace BluetoothButtonCapture
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var selector = BluetoothDevice.GetDeviceSelector();
            var devices = await DeviceInformation.FindAllAsync(selector);

            // Assuming your headset is paired and connected
            var headset = devices.FirstOrDefault(d => d.Name.Contains("QCY"));

            if (headset != null)
            {
                var bluetoothDevice = await BluetoothDevice.FromIdAsync(headset.Id);
                var service = bluetoothDevice.GattServices.FirstOrDefault(s => s.Uuid == GattServiceUuids.GenericAccess);
                var characteristic = service?.GetCharacteristics(GattCharacteristicUuids.DeviceName).FirstOrDefault();

                if (characteristic != null)
                {
                    characteristic.ValueChanged += (sender, args) =>
                    {
                        // Handle button press here
                        var value = args.CharacteristicValue.ToArray();
                        Console.WriteLine($"Button pressed: {BitConverter.ToString(value)}");
                    };

                    await characteristic.WriteClientCharacteristicConfigurationDescriptorAsync(
                        GattClientCharacteristicConfigurationDescriptorValue.Notify);
                }
            }
        }
    }
}
