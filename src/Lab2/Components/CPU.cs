namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class CPU
{
    private CPU() { }
    public string? Name { get; init; }
    public string? Socket { get; init; }
    public bool IntegratedGraphics { get; init; }
    public int CoreCount { get; init; }
    public double CoreFrequency { get; init; }
    public int RAMFrequency { get; init; }
    public int TDP { get; init; }
    public int EnergyConsumption { get; init; }

    public class CPUBuilder
    {
        private string? name;
        private string? socket;
        private bool integratedGraphics;
        private int coreCount;
        private double coreFrequency;
        private int ramFrequency;
        private int tdp;
        private int energyConsumption;

        public CPUBuilder() { }

        public CPUBuilder(CPU cpu)
        {
            name = cpu.Name;
            coreCount = cpu.CoreCount;
            coreFrequency = cpu.CoreFrequency;
            integratedGraphics = cpu.IntegratedGraphics;
            socket = cpu.Socket;
            ramFrequency = cpu.RAMFrequency;
            tdp = cpu.TDP;
            energyConsumption = cpu.EnergyConsumption;
        }

        public CPUBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public CPUBuilder SetCoreFrequency(double frequency)
        {
            coreFrequency = frequency;
            return this;
        }

        public CPUBuilder SetCores(int cores)
        {
            coreCount = cores;
            return this;
        }

        public CPUBuilder SetSocket(string socket)
        {
            this.socket = socket;
            return this;
        }

        public CPUBuilder WithIntegratedGraphics()
        {
            integratedGraphics = true;
            return this;
        }

        public CPUBuilder WithoutIntegratedGraphics()
        {
            integratedGraphics = false;
            return this;
        }

        public CPUBuilder SetROMFrequencies(int ramFrequency)
        {
            this.ramFrequency = ramFrequency;
            return this;
        }

        public CPUBuilder SetTDP(int tdp)
        {
            this.tdp = tdp;
            return this;
        }

        public CPUBuilder SetEnergyConsumption(int energyConsumption)
        {
            this.energyConsumption = energyConsumption;
            return this;
        }

        public CPU Build()
        {
            return new CPU
            {
                Name = name,
                CoreCount = coreCount,
                CoreFrequency = coreFrequency,
                Socket = socket,
                RAMFrequency = ramFrequency,
                TDP = tdp,
                EnergyConsumption = energyConsumption,
                IntegratedGraphics = integratedGraphics,
            };
        }
    }
}
