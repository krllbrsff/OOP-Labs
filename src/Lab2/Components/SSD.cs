namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class SSD
{
    private SSD() { }
    public string? Name { get; init; }
    public string? ConnectionType { get; init; }
    public int CapacityGB { get; init; }
    public int MaxSpeed { get; init; }
    public int EnergyConsumption { get; init; }

    public class SSDBuilder
    {
        private string? _name;
        private string? _connectionType;
        private int _capacityGB;
        private int _maxSpeed;
        private int _energyConsumption;

        public SSDBuilder()
        {
        }

        public SSDBuilder(SSD ssd)
        {
            _name = ssd.Name;
            _connectionType = ssd.ConnectionType;
            _capacityGB = ssd.CapacityGB;
            _maxSpeed = ssd.MaxSpeed;
            _energyConsumption = ssd.EnergyConsumption;
        }

        public SSDBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public SSDBuilder SetConnectionType(string connectionType)
        {
            _connectionType = connectionType;
            return this;
        }

        public SSDBuilder SetCapacityGB(int capacityGB)
        {
            _capacityGB = capacityGB;
            return this;
        }

        public SSDBuilder SetMaxSpeed(int maxSpeed)
        {
            _maxSpeed = maxSpeed;
            return this;
        }

        public SSDBuilder SetPowerConsumption(int energyConsumption)
        {
            _energyConsumption = energyConsumption;
            return this;
        }

        public SSD Build()
        {
            return new SSD
            {
                Name = _name,
                ConnectionType = _connectionType,
                CapacityGB = _capacityGB,
                MaxSpeed = _maxSpeed,
                EnergyConsumption = _energyConsumption,
            };
        }
    }
}
