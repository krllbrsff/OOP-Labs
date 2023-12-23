using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class CPUCooler
{
    private CPUCooler() { }

    public string? Name { get; init; }
    public string? Dimensions { get; init; }
    public Collection<string>? SupportedSockets { get; init; }
    public int MaxTDP { get; init; }

    public class CPUCoolerBuilder
    {
        private string? _name;
        private string? _dimensions;
        private Collection<string>? _supportedSockets;
        private int _maxTDP;

        public CPUCoolerBuilder()
        {
        }

        public CPUCoolerBuilder(CPUCooler cpuCooler)
        {
            _name = cpuCooler.Name;
            _dimensions = cpuCooler.Dimensions;
            _supportedSockets = cpuCooler.SupportedSockets;
            _maxTDP = cpuCooler.MaxTDP;
        }

        public CPUCoolerBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public CPUCoolerBuilder SetDimensions(string dimensions)
        {
            _dimensions = dimensions;
            return this;
        }

        public CPUCoolerBuilder SetSupportedSockets(Collection<string> supportedSockets)
        {
            _supportedSockets = supportedSockets;
            return this;
        }

        public CPUCoolerBuilder SetMaxTDP(int maxTDP)
        {
            _maxTDP = maxTDP;
            return this;
        }

        public CPUCooler Build()
        {
            return new CPUCooler
            {
                Name = _name,
                Dimensions = _dimensions,
                SupportedSockets = _supportedSockets,
                MaxTDP = _maxTDP,
            };
        }
    }
}
