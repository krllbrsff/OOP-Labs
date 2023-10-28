namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class WiFiAdapter
{
    private WiFiAdapter() { }
    public string? Name { get; private set; }
    public string? WiFiStandardVersion { get; private set; }
    public bool BluetoothModule { get; private set; }
    public double PCIEVersion { get; private set; }
    public int PowerConsumption { get; private set; }

    public class WiFiAdapterBuilder
    {
        private string? name;
        private string? wifiStandardVersion;
        private bool bluetoothModule;
        private double pcieVersion;
        private int powerConsumption;

        public WiFiAdapterBuilder() { }

        public WiFiAdapterBuilder(WiFiAdapter wifiAdapter)
        {
            name = wifiAdapter.Name;
            wifiStandardVersion = wifiAdapter.WiFiStandardVersion;
            bluetoothModule = wifiAdapter.BluetoothModule;
            pcieVersion = wifiAdapter.PCIEVersion;
            powerConsumption = wifiAdapter.PowerConsumption;
        }

        public WiFiAdapterBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public WiFiAdapterBuilder SetWiFiStandardVersion(string wifiStandardVersion)
        {
            this.wifiStandardVersion = wifiStandardVersion;
            return this;
        }

        public WiFiAdapterBuilder WithBluetoothModule()
        {
            bluetoothModule = true;
            return this;
        }

        public WiFiAdapterBuilder WithoutBluetoothModule()
        {
            bluetoothModule = false;
            return this;
        }

        public WiFiAdapterBuilder SetPCIEVersion(double pcieVersion)
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
            return new WiFiAdapter
            {
                Name = name,
                WiFiStandardVersion = wifiStandardVersion,
                BluetoothModule = bluetoothModule,
                PCIEVersion = pcieVersion,
                PowerConsumption = powerConsumption,
            };
        }
    }
}
