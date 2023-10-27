namespace Itmo.ObjectOrientedProgramming.Lab2.Components;
public class WiFiAdapter
{
    public WiFiAdapter(string wifiStandardVersion, bool hasBluetoothModule, string pcieVersion, int powerConsumption)
    {
        WiFiStandardVersion = wifiStandardVersion;
        HasBluetoothModule = hasBluetoothModule;
        PCIEVersion = pcieVersion;
        PowerConsumption = powerConsumption;
    }

    public string WiFiStandardVersion { get; }
    public bool HasBluetoothModule { get; }
    public string PCIEVersion { get; }
    public int PowerConsumption { get; }
}
