namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class XMPProfile
{
    private XMPProfile() { }
    public string? Name { get; init; }
    public int Frequency { get; init; }
    public double Voltage { get; init; }

    public class XMPProfileBuilder
    {
        private string? _name;
        private int _frequency;
        private double _voltage;

        public XMPProfileBuilder() { }

        public XMPProfileBuilder(XMPProfile xmpProfile)
        {
            _name = xmpProfile.Name;
            _frequency = xmpProfile.Frequency;
            _voltage = xmpProfile.Voltage;
        }

        public XMPProfileBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public XMPProfileBuilder SetFrequency(int frequency)
        {
            _frequency = frequency;
            return this;
        }

        public XMPProfileBuilder SetVoltage(double voltage)
        {
            _voltage = voltage;
            return this;
        }

        public XMPProfile Build()
        {
            return new XMPProfile
            {
                Name = _name,
                Frequency = _frequency,
                Voltage = _voltage,
            };
        }
    }
}
