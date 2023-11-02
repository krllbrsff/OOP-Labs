namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class XMPProfile
{
    private XMPProfile() { }
    public string? Name { get; init; }
    public int Frequency { get; init; }
    public double Voltage { get; init; }

    public class XMPProfileBuilder
    {
        private string? name;
        private int frequency;
        private double voltage;

        public XMPProfileBuilder() { }

        public XMPProfileBuilder(XMPProfile xmpProfile)
        {
            name = xmpProfile.Name;
            frequency = xmpProfile.Frequency;
            voltage = xmpProfile.Voltage;
        }

        public XMPProfileBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public XMPProfileBuilder SetFrequency(int frequency)
        {
            this.frequency = frequency;
            return this;
        }

        public XMPProfileBuilder SetVoltage(double voltage)
        {
            this.voltage = voltage;
            return this;
        }

        public XMPProfile Build()
        {
            return new XMPProfile
            {
                Name = name,
                Frequency = frequency,
                Voltage = voltage,
            };
        }
    }
}
