namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class WiFiAdapter
{
    private WiFiAdapter() { }
    public string? Name { get; init; }
    public string? WiFiStandardVersion { get; init; }
    public bool BluetoothModule { get; init; }
    public double PCIEVersion { get; init; }
    public int EnergyConsumption { get; init; }

    public class WiFiAdapterBuilder
    {
        private string? name;
        private string? wifiStandardVersion;
        private bool bluetoothModule;
        private double pcieVersion;
        private int energyConsumption;

        public WiFiAdapterBuilder() { }

        public WiFiAdapterBuilder(WiFiAdapter wifiAdapter)
        {
            name = wifiAdapter.Name;
            wifiStandardVersion = wifiAdapter.WiFiStandardVersion;
            bluetoothModule = wifiAdapter.BluetoothModule;
            pcieVersion = wifiAdapter.PCIEVersion;
            energyConsumption = wifiAdapter.EnergyConsumption;
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

        public WiFiAdapterBuilder SetPowerConsumption(int energyConsumption)
        {
            this.energyConsumption = energyConsumption;
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
                EnergyConsumption = energyConsumption,
            };
        }
    }
}
