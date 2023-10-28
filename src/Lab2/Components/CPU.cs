namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class CPU
{
    private CPU() { }
    public string? Name { get; private set; }
    public string? Socket { get; private set; }
    public bool IntegratedGraphics { get; private set; }
    public int CoreCount { get; private set; }
    public double CoreFrequency { get; private set; }
    public string? ROMFrequencies { get; private set; }
    public int TDP { get; private set; }
    public int EnergyConsumption { get; private set; }

    public class CPUBuilder
    {
        private string? name;
        private string? socket;
        private bool integratedGraphics;
        private int coreCount;
        private double coreFrequency;
        private string? romFrequencies;
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
            romFrequencies = cpu.ROMFrequencies;
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

        public CPUBuilder SetROMFrequencies(string romFrequencies)
        {
            this.romFrequencies = romFrequencies;
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
                ROMFrequencies = romFrequencies,
                TDP = tdp,
                EnergyConsumption = energyConsumption,
                IntegratedGraphics = integratedGraphics,
            };
        }
    }
}
