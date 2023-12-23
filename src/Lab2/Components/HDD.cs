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
        private string? _name;
        private int _capacityGB;
        private int _spindleSpeed;
        private int _energyConsumption;

        public HDDBuilder() { }

        public HDDBuilder(HDD hdd)
        {
            _name = hdd.Name;
            _capacityGB = hdd.CapacityGB;
            _spindleSpeed = hdd.SpindleSpeed;
            _energyConsumption = hdd.EnergyConsumption;
        }

        public HDDBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public HDDBuilder SetCapacityGB(int capacityGB)
        {
            _capacityGB = capacityGB;
            return this;
        }

        public HDDBuilder SetSpindleSpeed(int spindleSpeed)
        {
            _spindleSpeed = spindleSpeed;
            return this;
        }

        public HDDBuilder SetPowerConsumption(int energyConsumption)
        {
            _energyConsumption = energyConsumption;
            return this;
        }

        public HDD Build()
        {
            return new HDD
            {
                Name = _name,
                CapacityGB = _capacityGB,
                SpindleSpeed = _spindleSpeed,
                EnergyConsumption = _energyConsumption,
            };
        }
    }
}
