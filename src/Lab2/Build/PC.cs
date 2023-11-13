using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Build;

public class PC
{
    private PC() { }

    public CPU? CPU { get; init; }
    public GPU? GPU { get; init; }
    public Motherboard? Motherboard { get; init; }
    public CPUCooler? CPUCooler { get; init; }
    public Collection<RAM>? RAM { get; init; }
    public Collection<HDD>? HDD { get; init; }
    public Collection<SSD>? SSD { get; init; }
    public WiFiAdapter? WiFiAdapter { get; init; }
    public Corpus? Corpus { get; init; }
    public PowerSupply? PowerSupply { get; init; }

    public class PCBuilder
    {
        private CPU? _cpu;
        private GPU? _gpu;
        private Motherboard? _motherboard;
        private CPUCooler? _cpuCooler;
        private Collection<RAM>? _ram;
        private Collection<HDD>? _hdd;
        private Collection<SSD>? _ssd;
        private WiFiAdapter? _wifiAdapter;
        private Corpus? _corpus;
        private PowerSupply? _powerSupply;

        public PCBuilder()
        {
            _ram = new Collection<RAM>();
            _ssd = new Collection<SSD>();
            _hdd = new Collection<HDD>();
        }

        public PCBuilder(PC pc)
        {
            _cpu = pc.CPU;
            _gpu = pc.GPU;
            _motherboard = pc.Motherboard;
            _cpuCooler = pc.CPUCooler;
            _ram = pc.RAM;
            _hdd = pc.HDD;
            _ssd = pc.SSD;
            _wifiAdapter = pc.WiFiAdapter;
            _corpus = pc.Corpus;
            _powerSupply = pc.PowerSupply;
        }

        public PCBuilder SetCPU(CPU cpu)
        {
            _cpu = cpu;
            return this;
        }

        public PCBuilder SetGPU(GPU? gpu)
        {
            _gpu = gpu;
            return this;
        }

        public PCBuilder SetMotherboard(Motherboard motherboard)
        {
            _motherboard = motherboard;
            return this;
        }

        public PCBuilder SetCPUCooler(CPUCooler cpuCooler)
        {
            _cpuCooler = cpuCooler;
            return this;
        }

        public PCBuilder SetRAM(RAM ram)
        {
            _ram?.Add(ram);
            return this;
        }

        public PCBuilder SetHDD(HDD hdd)
        {
            _hdd?.Add(hdd);
            return this;
        }

        public PCBuilder SetSSD(SSD ssd)
        {
            _ssd?.Add(ssd);
            return this;
        }

        public PCBuilder SetWiFiAdapter(WiFiAdapter? wifiAdapter)
        {
            _wifiAdapter = wifiAdapter;
            return this;
        }

        public PCBuilder SetCorpus(Corpus corpus)
        {
            _corpus = corpus;
            return this;
        }

        public PCBuilder SetPowerSupply(PowerSupply powerSupply)
        {
            _powerSupply = powerSupply;
            return this;
        }

        public PC Build()
        {
            return new PC
            {
                CPU = _cpu,
                RAM = _ram,
                HDD = _hdd,
                SSD = _ssd,
                GPU = _gpu,
                Motherboard = _motherboard,
                CPUCooler = _cpuCooler,
                Corpus = _corpus,
                PowerSupply = _powerSupply,
                WiFiAdapter = _wifiAdapter,
            };
        }
    }
}
