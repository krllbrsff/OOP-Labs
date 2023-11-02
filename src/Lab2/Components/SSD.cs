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
        private string? name;
        private string? connectionType;
        private int capacityGB;
        private int maxSpeed;
        private int energyConsumption;

        public SSDBuilder()
        {
        }

        public SSDBuilder(SSD ssd)
        {
            name = ssd.Name;
            connectionType = ssd.ConnectionType;
            capacityGB = ssd.CapacityGB;
            maxSpeed = ssd.MaxSpeed;
            energyConsumption = ssd.EnergyConsumption;
        }

        public SSDBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public SSDBuilder SetConnectionType(string connectionType)
        {
            this.connectionType = connectionType;
            return this;
        }

        public SSDBuilder SetCapacityGB(int capacityGB)
        {
            this.capacityGB = capacityGB;
            return this;
        }

        public SSDBuilder SetMaxSpeed(int maxSpeed)
        {
            this.maxSpeed = maxSpeed;
            return this;
        }

        public SSDBuilder SetPowerConsumption(int energyConsumption)
        {
            this.energyConsumption = energyConsumption;
            return this;
        }

        public SSD Build()
        {
            return new SSD
            {
                Name = name,
                ConnectionType = connectionType,
                CapacityGB = capacityGB,
                MaxSpeed = maxSpeed,
                EnergyConsumption = energyConsumption,
            };
        }
    }
}
