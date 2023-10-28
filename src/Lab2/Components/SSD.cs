namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class SSD
{
    private SSD() { }
    public string? Name { get; private set; }
    public string? ConnectionType { get; private set; }
    public int CapacityGB { get; private set; }
    public int MaxSpeed { get; private set; }
    public int PowerConsumption { get; private set; }

    public class SSDBuilder
    {
        private string? name;
        private string? connectionType;
        private int capacityGB;
        private int maxSpeed;
        private int powerConsumption;

        public SSDBuilder()
        {
        }

        public SSDBuilder(SSD ssd)
        {
            name = ssd.Name;
            connectionType = ssd.ConnectionType;
            capacityGB = ssd.CapacityGB;
            maxSpeed = ssd.MaxSpeed;
            powerConsumption = ssd.PowerConsumption;
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

        public SSDBuilder SetPowerConsumption(int powerConsumption)
        {
            this.powerConsumption = powerConsumption;
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
                PowerConsumption = powerConsumption,
            };
        }
    }
}
