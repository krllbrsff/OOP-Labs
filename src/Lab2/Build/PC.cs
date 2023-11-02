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
        private CPU? cpu;
        private GPU? gpu;
        private Motherboard? motherboard;
        private CPUCooler? cpuCooler;
        private Collection<RAM>? ram;
        private Collection<HDD>? hdd;
        private Collection<SSD>? ssd;
        private WiFiAdapter? wifiAdapter;
        private Corpus? corpus;
        private PowerSupply? powerSupply;

        public PCBuilder()
        {
            ram = new Collection<RAM>();
            ssd = new Collection<SSD>();
            hdd = new Collection<HDD>();
        }

        public PCBuilder(PC pc)
        {
            cpu = pc.CPU;
            gpu = pc.GPU;
            motherboard = pc.Motherboard;
            cpuCooler = pc.CPUCooler;
            ram = pc.RAM;
            hdd = pc.HDD;
            ssd = pc.SSD;
            wifiAdapter = pc.WiFiAdapter;
            corpus = pc.Corpus;
            powerSupply = pc.PowerSupply;
        }

        public PCBuilder SetCPU(CPU cpu)
        {
            this.cpu = cpu;
            return this;
        }

        public PCBuilder SetGPU(GPU? gpu)
        {
            this.gpu = gpu;
            return this;
        }

        public PCBuilder SetMotherboard(Motherboard motherboard)
        {
            this.motherboard = motherboard;
            return this;
        }

        public PCBuilder SetCPUCooler(CPUCooler cpuCooler)
        {
            this.cpuCooler = cpuCooler;
            return this;
        }

        public PCBuilder SetRAM(RAM ram)
        {
            this.ram?.Add(ram);
            return this;
        }

        public PCBuilder SetHDD(HDD hdd)
        {
            this.hdd?.Add(hdd);
            return this;
        }

        public PCBuilder SetSSD(SSD ssd)
        {
            this.ssd?.Add(ssd);
            return this;
        }

        public PCBuilder SetWiFiAdapter(WiFiAdapter? wifiAdapter)
        {
            this.wifiAdapter = wifiAdapter;
            return this;
        }

        public PCBuilder SetCorpus(Corpus corpus)
        {
            this.corpus = corpus;
            return this;
        }

        public PCBuilder SetPowerSupply(PowerSupply powerSupply)
        {
            this.powerSupply = powerSupply;
            return this;
        }

        public PC Build()
        {
            return new PC
            {
                CPU = cpu,
                RAM = ram,
                HDD = hdd,
                SSD = ssd,
                GPU = gpu,
                Motherboard = motherboard,
                CPUCooler = cpuCooler,
                Corpus = corpus,
                PowerSupply = powerSupply,
                WiFiAdapter = wifiAdapter,
            };
        }
    }
}
