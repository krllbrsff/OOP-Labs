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
        private string? name;
        private string? dimensions;
        private Collection<string>? supportedSockets;
        private int maxTDP;

        public CPUCoolerBuilder()
        {
        }

        public CPUCoolerBuilder(CPUCooler cpuCooler)
        {
            name = cpuCooler.Name;
            dimensions = cpuCooler.Dimensions;
            supportedSockets = cpuCooler.SupportedSockets;
            maxTDP = cpuCooler.MaxTDP;
        }

        public CPUCoolerBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public CPUCoolerBuilder SetDimensions(string dimensions)
        {
            this.dimensions = dimensions;
            return this;
        }

        public CPUCoolerBuilder SetSupportedSockets(Collection<string> supportedSockets)
        {
            this.supportedSockets = supportedSockets;
            return this;
        }

        public CPUCoolerBuilder SetMaxTDP(int maxTDP)
        {
            this.maxTDP = maxTDP;
            return this;
        }

        public CPUCooler Build()
        {
            return new CPUCooler
            {
                Name = name,
                Dimensions = dimensions,
                SupportedSockets = supportedSockets,
                MaxTDP = maxTDP,
            };
        }
    }
}
