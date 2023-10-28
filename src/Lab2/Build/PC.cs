using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Build;

public class PC
{
    private PC() { }

    public CPU? CPU { get; private set; }
    public GPU? GPU { get; private set; }
    public Motherboard? Motherboard { get; private set; }
    public CPUCooler? CPUCooler { get; private set; }
    public ReadOnlyCollection<RAM>? RAM { get; private set; }
    public ReadOnlyCollection<HDD>? HDD { get; private set; }
    public ReadOnlyCollection<SSD>? SSD { get; private set; }
    public WiFiAdapter? WiFiAdapter { get; private set; }
    public Corpus? Corpus { get; private set; }
    public PowerSupply? PowerSupply { get; private set; }

    public class PCBuilder
    {
        private CPU? cpu;
        private GPU? gpu;
        private Motherboard? motherboard;
        private CPUCooler? cpuCooler;
        private ReadOnlyCollection<RAM>? ram;
        private ReadOnlyCollection<HDD>? hdd;
        private ReadOnlyCollection<SSD>? ssd;
        private WiFiAdapter? wifiAdapter;
        private Corpus? corpus;
        private PowerSupply? powerSupply;

        public PCBuilder() { }

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

        public PCBuilder SetRAM(ReadOnlyCollection<RAM> ram)
        {
            this.ram = ram;
            return this;
        }

        public PCBuilder SetHDD(ReadOnlyCollection<HDD>? hdd)
        {
            this.hdd = hdd;
            return this;
        }

        public PCBuilder SetSSD(ReadOnlyCollection<SSD>? ssd)
        {
            this.ssd = ssd;
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
