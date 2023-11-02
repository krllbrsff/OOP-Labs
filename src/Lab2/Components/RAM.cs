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
        private string? name;
        private int capacityGB;
        private int frequency;
        private double voltage;
        private Collection<XMPProfile>? xmpProfiles;
        private string? formFactor;
        private string? ddrVersion;
        private int energyConsumption;

        public RAMBuilder()
        {
            xmpProfiles = new Collection<XMPProfile>();
        }

        public RAMBuilder(RAM ram)
        {
            name = ram.Name;
            capacityGB = ram.CapacityGB;
            frequency = ram.Frequency;
            voltage = ram.Voltage;
            xmpProfiles = ram.XMPProfiles;
            formFactor = ram.FormFactor;
            ddrVersion = ram.DDRVersion;
            energyConsumption = ram.EnergyConsumption;
        }

        public RAMBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public RAMBuilder SetCapacityGB(int capacityGB)
        {
            this.capacityGB = capacityGB;
            return this;
        }

        public RAMBuilder SetFrequency(int frequency)
        {
            this.frequency = frequency;
            return this;
        }

        public RAMBuilder SetVoltage(double voltage)
        {
            this.voltage = voltage;
            return this;
        }

        public RAMBuilder AddXMPProfile(XMPProfile xmpProfile)
        {
            if (xmpProfiles == null)
            {
                xmpProfiles = new Collection<XMPProfile>();
            }

            xmpProfiles.Add(xmpProfile);
            return this;
        }

        public RAMBuilder SetFormFactor(string formFactor)
        {
            this.formFactor = formFactor;
            return this;
        }

        public RAMBuilder SetDDRVersion(string ddrVersion)
        {
            this.ddrVersion = ddrVersion;
            return this;
        }

        public RAMBuilder SetPowerConsumption(int energyConsumption)
        {
            this.energyConsumption = energyConsumption;
            return this;
        }

        public RAM Build()
        {
            return new RAM
            {
                Name = name,
                CapacityGB = capacityGB,
                Frequency = frequency,
                Voltage = voltage,
                XMPProfiles = xmpProfiles,
                FormFactor = formFactor,
                DDRVersion = ddrVersion,
                EnergyConsumption = energyConsumption,
            };
        }
    }
}
