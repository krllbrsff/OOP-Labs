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
        private string? _name;
        private string? _wifiStandardVersion;
        private bool _bluetoothModule;
        private double _pcieVersion;
        private int _energyConsumption;

        public WiFiAdapterBuilder() { }

        public WiFiAdapterBuilder(WiFiAdapter wifiAdapter)
        {
            _name = wifiAdapter.Name;
            _wifiStandardVersion = wifiAdapter.WiFiStandardVersion;
            _bluetoothModule = wifiAdapter.BluetoothModule;
            _pcieVersion = wifiAdapter.PCIEVersion;
            _energyConsumption = wifiAdapter.EnergyConsumption;
        }

        public WiFiAdapterBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public WiFiAdapterBuilder SetWiFiStandardVersion(string wifiStandardVersion)
        {
            _wifiStandardVersion = wifiStandardVersion;
            return this;
        }

        public WiFiAdapterBuilder WithBluetoothModule()
        {
            _bluetoothModule = true;
            return this;
        }

        public WiFiAdapterBuilder WithoutBluetoothModule()
        {
            _bluetoothModule = false;
            return this;
        }

        public WiFiAdapterBuilder SetPCIEVersion(double pcieVersion)
        {
            _pcieVersion = pcieVersion;
            return this;
        }

        public WiFiAdapterBuilder SetPowerConsumption(int energyConsumption)
        {
            _energyConsumption = energyConsumption;
            return this;
        }

        public WiFiAdapter Build()
        {
            return new WiFiAdapter
            {
                Name = _name,
                WiFiStandardVersion = _wifiStandardVersion,
                BluetoothModule = _bluetoothModule,
                PCIEVersion = _pcieVersion,
                EnergyConsumption = _energyConsumption,
            };
        }
    }
}
