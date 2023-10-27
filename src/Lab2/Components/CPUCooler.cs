namespace Itmo.ObjectOrientedProgramming.Lab2.Components;
public class CPUCooler
{
    private CPUCooler(string dimensions, string supportedSockets, int maxTDP)
    {
        Dimensions = dimensions;
        SupportedSockets = supportedSockets;
        MaxTDP = maxTDP;
    }

    public string Dimensions { get; }
    public string SupportedSockets { get; }
    public int MaxTDP { get; }

    public class CPUCoolerBuilder
    {
        private string dimensions;
        private string supportedSockets;
        private int maxTDP;

        public CPUCoolerBuilder(CPUCooler cpuCooler)
        {
            dimensions = cpuCooler.Dimensions;
            supportedSockets = cpuCooler.SupportedSockets;
            maxTDP = cpuCooler.MaxTDP;
        }

        public CPUCoolerBuilder SetDimensions(string dimensions)
        {
            this.dimensions = dimensions;
            return this;
        }

        public CPUCoolerBuilder SetSupportedSockets(string supportedSockets)
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
            return new CPUCooler(dimensions, supportedSockets, maxTDP);
        }
    }
}
