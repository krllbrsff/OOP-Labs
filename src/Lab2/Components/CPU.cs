using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Components;
public class CPU
{
    private CPU(string name, int coreCount, double coreFrequency, string socket, string romFrequencies, int tdp, int energyConsumption, bool integratedGraphics)
    {
        Name = name;
        CoreCount = coreCount;
        CoreFrequency = coreFrequency;
        Socket = socket;
        ROMFrequencies = romFrequencies;
        TDP = tdp;
        EnergyConsumption = energyConsumption;
        IntegratedGraphics = integratedGraphics;
    }

    public string? Name { get; }
    public string? Socket { get; }
    public bool IntegratedGraphics { get; }
    public int CoreCount { get; }
    public double CoreFrequency { get; }
    public string? ROMFrequencies { get; }
    public int TDP { get; }
    public int EnergyConsumption { get; }

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

        public CPUBuilder(CPU cpu)
        {
            if (cpu == null) throw new ArgumentNullException(nameof(cpu));

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

        public CPUBuilder AddIntegratedGraphics()
        {
            integratedGraphics = true;
            return this;
        }

        public CPUBuilder RemoveIntegratedGraphics()
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
            return new CPU(name ?? string.Empty, coreCount, coreFrequency, socket ?? string.Empty, romFrequencies ?? string.Empty, tdp, energyConsumption, integratedGraphics);
        }
    }
}