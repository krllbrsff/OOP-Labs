using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class RAM
{
    private RAM() { }
    public string? Name { get; init; }
    public int CapacityGB { get; init; }
    public int Frequency { get; init; }
    public double Voltage { get; init; }
    public Collection<XMPProfile>? XMPProfiles { get; init; }
    public string? FormFactor { get; init; }
    public string? DDRVersion { get; init; }
    public int EnergyConsumption { get; init; }

    public class RAMBuilder
    {
        private string? _name;
        private int _capacityGB;
        private int _frequency;
        private double _voltage;
        private Collection<XMPProfile>? _xmpProfiles;
        private string? _formFactor;
        private string? _ddrVersion;
        private int _energyConsumption;

        public RAMBuilder()
        {
            _xmpProfiles = new Collection<XMPProfile>();
        }

        public RAMBuilder(RAM ram)
        {
            _name = ram.Name;
            _capacityGB = ram.CapacityGB;
            _frequency = ram.Frequency;
            _voltage = ram.Voltage;
            _xmpProfiles = ram.XMPProfiles;
            _formFactor = ram.FormFactor;
            _ddrVersion = ram.DDRVersion;
            _energyConsumption = ram.EnergyConsumption;
        }

        public RAMBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public RAMBuilder SetCapacityGB(int capacityGB)
        {
            _capacityGB = capacityGB;
            return this;
        }

        public RAMBuilder SetFrequency(int frequency)
        {
            _frequency = frequency;
            return this;
        }

        public RAMBuilder SetVoltage(double voltage)
        {
            _voltage = voltage;
            return this;
        }

        public RAMBuilder AddXMPProfile(XMPProfile xmpProfile)
        {
            _xmpProfiles ??= new Collection<XMPProfile>();

            _xmpProfiles.Add(xmpProfile);
            return this;
        }

        public RAMBuilder SetFormFactor(string formFactor)
        {
            _formFactor = formFactor;
            return this;
        }

        public RAMBuilder SetDDRVersion(string ddrVersion)
        {
            _ddrVersion = ddrVersion;
            return this;
        }

        public RAMBuilder SetPowerConsumption(int energyConsumption)
        {
            _energyConsumption = energyConsumption;
            return this;
        }

        public RAM Build()
        {
            return new RAM
            {
                Name = _name,
                CapacityGB = _capacityGB,
                Frequency = _frequency,
                Voltage = _voltage,
                XMPProfiles = _xmpProfiles,
                FormFactor = _formFactor,
                DDRVersion = _ddrVersion,
                EnergyConsumption = _energyConsumption,
            };
        }
    }
}
