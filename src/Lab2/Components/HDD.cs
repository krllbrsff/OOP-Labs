namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class HDD
{
    private HDD() { }
    public string? Name { get; init; }
    public int CapacityGB { get; init; }
    public int SpindleSpeed { get; init; }
    public int EnergyConsumption { get; init; }

    public class HDDBuilder
    {
        private string? name;
        private int capacityGB;
        private int spindleSpeed;
        private int energyConsumption;

        public HDDBuilder() { }

        public HDDBuilder(HDD hdd)
        {
            name = hdd.Name;
            capacityGB = hdd.CapacityGB;
            spindleSpeed = hdd.SpindleSpeed;
            energyConsumption = hdd.EnergyConsumption;
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

        public HDDBuilder SetPowerConsumption(int energyConsumption)
        {
            this.energyConsumption = energyConsumption;
            return this;
        }

        public HDD Build()
        {
            return new HDD
            {
                Name = name,
                CapacityGB = capacityGB,
                SpindleSpeed = spindleSpeed,
                EnergyConsumption = energyConsumption,
            };
        }
    }
}
