namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class HDD
{
    private HDD() { }
    public string? Name { get; private set; }
    public int CapacityGB { get; private set; }
    public int SpindleSpeed { get; private set; }
    public int PowerConsumption { get; private set; }

    public class HDDBuilder
    {
        private string? name;
        private int capacityGB;
        private int spindleSpeed;
        private int powerConsumption;

        public HDDBuilder() { }

        public HDDBuilder(HDD hdd)
        {
            name = hdd.Name;
            capacityGB = hdd.CapacityGB;
            spindleSpeed = hdd.SpindleSpeed;
            powerConsumption = hdd.PowerConsumption;
        }

        public HDDBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public HDDBuilder SetCapacityGB(int capacityGB)
        {
            this.capacityGB = capacityGB;
            return this;
        }

        public HDDBuilder SetSpindleSpeed(int spindleSpeed)
        {
            this.spindleSpeed = spindleSpeed;
            return this;
        }

        public HDDBuilder SetPowerConsumption(int powerConsumption)
        {
            this.powerConsumption = powerConsumption;
            return this;
        }

        public HDD Build()
        {
            return new HDD
            {
                Name = name,
                CapacityGB = capacityGB,
                SpindleSpeed = spindleSpeed,
                PowerConsumption = powerConsumption,
            };
        }
    }
}
