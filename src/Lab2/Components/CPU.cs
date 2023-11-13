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
        private string? _name;
        private string? _socket;
        private bool _integratedGraphics;
        private int _coreCount;
        private double _coreFrequency;
        private int _ramFrequency;
        private int _tdp;
        private int _energyConsumption;

        public CPUBuilder() { }

        public CPUBuilder(CPU cpu)
        {
            _name = cpu.Name;
            _coreCount = cpu.CoreCount;
            _coreFrequency = cpu.CoreFrequency;
            _integratedGraphics = cpu.IntegratedGraphics;
            _socket = cpu.Socket;
            _ramFrequency = cpu.RAMFrequency;
            _tdp = cpu.TDP;
            _energyConsumption = cpu.EnergyConsumption;
        }

        public CPUBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public CPUBuilder SetCoreFrequency(double frequency)
        {
            _coreFrequency = frequency;
            return this;
        }

        public CPUBuilder SetCores(int cores)
        {
            _coreCount = cores;
            return this;
        }

        public CPUBuilder SetSocket(string socket)
        {
            _socket = socket;
            return this;
        }

        public CPUBuilder WithIntegratedGraphics()
        {
            _integratedGraphics = true;
            return this;
        }

        public CPUBuilder WithoutIntegratedGraphics()
        {
            _integratedGraphics = false;
            return this;
        }

        public CPUBuilder SetROMFrequencies(int ramFrequency)
        {
            _ramFrequency = ramFrequency;
            return this;
        }

        public CPUBuilder SetTDP(int tdp)
        {
            _tdp = tdp;
            return this;
        }

        public CPUBuilder SetEnergyConsumption(int energyConsumption)
        {
            _energyConsumption = energyConsumption;
            return this;
        }

        public CPU Build()
        {
            return new CPU
            {
                Name = _name,
                CoreCount = _coreCount,
                CoreFrequency = _coreFrequency,
                Socket = _socket,
                RAMFrequency = _ramFrequency,
                TDP = _tdp,
                EnergyConsumption = _energyConsumption,
                IntegratedGraphics = _integratedGraphics,
            };
        }
    }
}
