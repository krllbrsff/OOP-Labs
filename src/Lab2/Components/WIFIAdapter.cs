namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class WiFiAdapter
{
    private WiFiAdapter(string wifiStandardVersion, bool hasBluetoothModule, string pcieVersion, int powerConsumption)
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

    public class WiFiAdapterBuilder
    {
        private string wifiStandardVersion;
        private bool hasBluetoothModule;
        private string pcieVersion;
        private int powerConsumption;

        public WiFiAdapterBuilder(WiFiAdapter wifiAdapter)
        {
            wifiStandardVersion = wifiAdapter.WiFiStandardVersion;
            hasBluetoothModule = wifiAdapter.HasBluetoothModule;
            pcieVersion = wifiAdapter.PCIEVersion;
            powerConsumption = wifiAdapter.PowerConsumption;
        }

        public WiFiAdapterBuilder SetWiFiStandardVersion(string wifiStandardVersion)
        {
            this.wifiStandardVersion = wifiStandardVersion;
            return this;
        }

        public WiFiAdapterBuilder SetHasBluetoothModule(bool hasBluetoothModule)
        {
            this.hasBluetoothModule = hasBluetoothModule;
            return this;
        }

        public WiFiAdapterBuilder SetPCIEVersion(string pcieVersion)
        {
            this.pcieVersion = pcieVersion;
            return this;
        }

        public WiFiAdapterBuilder SetPowerConsumption(int powerConsumption)
        {
            this.powerConsumption = powerConsumption;
            return this;
        }

        public WiFiAdapter Build()
        {
            return new WiFiAdapter(wifiStandardVersion, hasBluetoothModule, pcieVersion, powerConsumption);
        }
    }
}
