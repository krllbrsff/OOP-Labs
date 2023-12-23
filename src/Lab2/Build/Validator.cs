using System;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Build;
public class Validator
{
    public Validator(PC pc)
    {
        PC = pc;
    }

    public PC PC { get; }

    public Result Validate()
    {
        if (PC.Motherboard is null) return Result.NecesseryComponentMissed;
        if (PC.Motherboard.Socket != PC.CPU?.Socket) return Result.CPUMotherboardConflict;

        if (PC.RAM is null) return Result.NecesseryComponentMissed;
        if (PC.Motherboard.Chipset?.MemoryFrequencies is null) throw new ArgumentNullException(nameof(Motherboard));
        foreach (RAM ram in PC.RAM)
        {
            if (PC.Motherboard.DDRStandard != ram.DDRVersion) return Result.MotherboardRAMConflict;
            if (!PC.Motherboard.Chipset.MemoryFrequencies.Contains(ram.Frequency)) return Result.MotherboardRAMConflict;
            if (PC.CPU?.RAMFrequency < ram.Frequency) return Result.MotherboardRAMConflict;
        }

        if (PC.RAM.Count > PC.Motherboard.RamSlots) return Result.MotherboardRAMConflict;

        if (PC.Corpus is null) return Result.NecesseryComponentMissed;
        if (PC.Corpus.SupportedMotherboardFormats is null) throw new ArgumentNullException(nameof(Corpus));
        if (PC.Motherboard.FormFactor is null) throw new ArgumentNullException(nameof(Motherboard));
        if (!PC.Corpus.SupportedMotherboardFormats.Contains(PC.Motherboard.FormFactor)) return Result.MotherboardCorpusConflict;
        if (PC.Corpus.MaxGPUSize < PC.GPU?.Height) return Result.GPUCorpusConflict;

        if (PC.CPU?.TDP > PC.CPUCooler?.MaxTDP) return Result.WithoutGuarantee;

        if (PC.SSD is null && PC.HDD is null) return Result.NecesseryComponentMissed;
        int sataCount = 0, pcieCount = 0;
        if (PC.SSD != null)
        {
            if (PC.SSD.Count(ssd => ssd.ConnectionType == "SATA") + PC.HDD?.Count > PC.Motherboard.SATAPorts) return Result.MotherboardROMConflict;
            if (PC.SSD.Count(ssd => ssd.ConnectionType == "PCI-E") > PC.Motherboard.PCIELines) return Result.MotherboardROMConflict;
        }

        if (sataCount + pcieCount > PC.Motherboard.PCIELines) return Result.MotherboardROMConflict;

        if (PC.GPU is null && PC.CPU?.IntegratedGraphics is false) return Result.NecesseryComponentMissed;

        if ((PC.CPU?.EnergyConsumption ?? 0) +
            (PC.GPU?.EnergyConsumption ?? 0) +
            PC.RAM.Sum(ram => ram.EnergyConsumption) +
            (PC.SSD?.Sum(ssd => ssd.EnergyConsumption) ?? 0) +
            (PC.HDD?.Sum(hdd => hdd.EnergyConsumption) ?? 0) +
            (PC.WiFiAdapter?.EnergyConsumption ?? 0) > PC.PowerSupply?.Power) return Result.PowerSupplyPowerIsNotEnough;

        if ((PC.CPU?.EnergyConsumption ?? 0) +
            (PC.GPU?.EnergyConsumption ?? 0) +
            PC.RAM.Sum(ram => ram.EnergyConsumption) +
            (PC.SSD?.Sum(ssd => ssd.EnergyConsumption) ?? 0) +
            (PC.HDD?.Sum(hdd => hdd.EnergyConsumption) ?? 0) +
            (PC.WiFiAdapter?.EnergyConsumption ?? 0) > (PC.PowerSupply?.Power * 0.8)) return Result.LowPowerReserve;

        if (PC.CPUCooler?.SupportedSockets is null) throw new ArgumentNullException(nameof(CPUCooler));
        if (PC.Motherboard.Socket is null) throw new ArgumentNullException(nameof(Motherboard));
        if (!PC.CPUCooler.SupportedSockets.Contains(PC.Motherboard.Socket)) return Result.MotherboardCoolerConflict;

        return Result.PCIsValid;
    }
}