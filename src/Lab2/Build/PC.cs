using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Components;
using Newtonsoft.Json;

namespace Itmo.ObjectOrientedProgramming.Lab2.Build;
public class PC
{
    private PC(CPU cpu, GPU? gpu, Motherboard motherboard, CPUCooler cpuCooler, ReadOnlyCollection<RAM> ram, ReadOnlyCollection<HDD>? hdd, ReadOnlyCollection<SSD>? ssd, WiFiAdapter? wifiAdapter, Corpus corpus, PowerSupply powerSupply)
    {
        CPU = cpu;
        GPU = gpu;
        Motherboard = motherboard;
        CPUCooler = cpuCooler;
        RAM = ram;
        HDD = hdd;
        SSD = ssd;
        WiFiAdapter = wifiAdapter;
        Corpus = corpus;
        PowerSupply = powerSupply;
    }

    public CPU CPU { get; }
    public GPU? GPU { get; }
    public Motherboard Motherboard { get; }
    public CPUCooler CPUCooler { get; }
    public ReadOnlyCollection<RAM> RAM { get; }
    public ReadOnlyCollection<HDD>? HDD { get; }
    public ReadOnlyCollection<SSD>? SSD { get; }
    public WiFiAdapter? WiFiAdapter { get; }
    public Corpus Corpus { get; }
    public PowerSupply PowerSupply { get; }

    public class PCBuilder
    {
        private CPU cpu;
        private GPU? gpu;
        private Motherboard motherboard;
        private CPUCooler cpuCooler;
        private ReadOnlyCollection<RAM> ram;
        private ReadOnlyCollection<HDD>? hdd;
        private ReadOnlyCollection<SSD>? ssd;
        private WiFiAdapter? wifiAdapter;
        private Corpus corpus;
        private PowerSupply powerSupply;
        private PCBuilder(PC pc)
        {
            gpu = pc.GPU;
            cpu = pc.CPU;
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

        public PCBuilder SetCase(Corpus corpus)
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
            return new PC(cpu, gpu, motherboard, cpuCooler, ram, hdd, ssd, wifiAdapter, corpus, powerSupply);
        }
    }
}
