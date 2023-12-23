using System;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Build;
using Itmo.ObjectOrientedProgramming.Lab2.Stock;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab2.Tests;

public class Tests
{
    [Fact]
    public void ValidPC()
    {
        var stock = new ComponentsStock();
        PC pc = new PC.PCBuilder()
            .SetCPU(stock.CPUStock?.First(cpu => cpu.Name == "Intel Core i5-11600") ?? throw new ArgumentNullException(nameof(stock)))
            .SetMotherboard(stock.MotherboardStock?.First(motherboard => motherboard.Name == "ASUS ROG Strix Z590-E") ?? throw new ArgumentNullException(nameof(stock)))
            .SetRAM(stock.RAMStock?.First(ram => ram.Name == "Corsair Vengeance LPX 16GB") ?? throw new ArgumentNullException(nameof(stock)))
            .SetGPU(stock.GPUStock?.First(gpu => gpu.Name == "NVIDIA GeForce RTX 3070"))
            .SetCorpus(stock.CorpusStock?.First(corpus => corpus.Name == "NZXT H510") ?? throw new ArgumentNullException(nameof(stock)))
            .SetSSD(stock.SSDStock?.First(ssd => ssd.Name == "Samsung 970 EVO Plus 500GB") ?? throw new ArgumentNullException(nameof(stock)))
            .SetCPUCooler(stock.CoolerStock?.First(cooler => cooler.Name == "Noctua NH-D15") ?? throw new ArgumentNullException(nameof(stock)))
            .SetPowerSupply(stock.PowerSupplyStock?.First(powerSupply => powerSupply.Name == "Seasonic PRIME 850 Platinum") ?? throw new ArgumentNullException(nameof(stock)))
            .Build();
        Assert.Equal(Result.PCIsValid, new Validator(pc).Validate());
    }

    [Fact]
    public void LowPowerReservePC()
    {
        var stock = new ComponentsStock();
        PC pc = new PC.PCBuilder()
            .SetCPU(stock.CPUStock?.First(cpu => cpu.Name == "Intel Core i5-11600") ?? throw new ArgumentNullException(nameof(stock)))
            .SetMotherboard(stock.MotherboardStock?.First(motherboard => motherboard.Name == "ASUS ROG Strix Z590-E") ?? throw new ArgumentNullException(nameof(stock)))
            .SetRAM(stock.RAMStock?.First(ram => ram.Name == "Corsair Vengeance LPX 16GB") ?? throw new ArgumentNullException(nameof(stock)))
            .SetGPU(stock.GPUStock?.First(gpu => gpu.Name == "NVIDIA GeForce RTX 3070"))
            .SetCorpus(stock.CorpusStock?.First(corpus => corpus.Name == "NZXT H510") ?? throw new ArgumentNullException(nameof(stock)))
            .SetSSD(stock.SSDStock?.First(ssd => ssd.Name == "Samsung 970 EVO Plus 500GB") ?? throw new ArgumentNullException(nameof(stock)))
            .SetCPUCooler(stock.CoolerStock?.First(cooler => cooler.Name == "Noctua NH-D15") ?? throw new ArgumentNullException(nameof(stock)))
            .SetPowerSupply(stock.PowerSupplyStock?.First(powerSupply => powerSupply.Name == "Corsair CX420M") ?? throw new ArgumentNullException(nameof(stock)))
            .Build();
        Assert.Equal(Result.LowPowerReserve, new Validator(pc).Validate());
    }

    [Fact]
    public void PCWithLowCoolerTDP()
    {
        var stock = new ComponentsStock();
        PC pc = new PC.PCBuilder()
            .SetCPU(stock.CPUStock?.First(cpu => cpu.Name == "Intel Core i5-11600") ?? throw new ArgumentNullException(nameof(stock)))
            .SetMotherboard(stock.MotherboardStock?.First(motherboard => motherboard.Name == "ASUS ROG Strix Z590-E") ?? throw new ArgumentNullException(nameof(stock)))
            .SetRAM(stock.RAMStock?.First(ram => ram.Name == "Corsair Vengeance LPX 16GB") ?? throw new ArgumentNullException(nameof(stock)))
            .SetGPU(stock.GPUStock?.First(gpu => gpu.Name == "NVIDIA GeForce RTX 3070"))
            .SetCorpus(stock.CorpusStock?.First(corpus => corpus.Name == "NZXT H510") ?? throw new ArgumentNullException(nameof(stock)))
            .SetSSD(stock.SSDStock?.First(ssd => ssd.Name == "Samsung 970 EVO Plus 500GB") ?? throw new ArgumentNullException(nameof(stock)))
            .SetCPUCooler(stock.CoolerStock?.First(cooler => cooler.Name == "Noctua NH-D12") ?? throw new ArgumentNullException(nameof(stock)))
            .SetPowerSupply(stock.PowerSupplyStock?.First(powerSupply => powerSupply.Name == "Corsair CX650M") ?? throw new ArgumentNullException(nameof(stock)))
            .Build();
        Assert.Equal(Result.WithoutGuarantee, new Validator(pc).Validate());
    }

    [Fact]
    public void WrongCPU()
    {
        var stock = new ComponentsStock();
        PC pc = new PC.PCBuilder()
            .SetCPU(stock.CPUStock?.First(cpu => cpu.Name == "AMD Ryzen 9 5900X") ?? throw new ArgumentNullException(nameof(stock)))
            .SetMotherboard(stock.MotherboardStock?.First(motherboard => motherboard.Name == "ASUS ROG Strix Z590-E") ?? throw new ArgumentNullException(nameof(stock)))
            .SetRAM(stock.RAMStock?.First(ram => ram.Name == "Corsair Vengeance LPX 16GB") ?? throw new ArgumentNullException(nameof(stock)))
            .SetGPU(stock.GPUStock?.First(gpu => gpu.Name == "NVIDIA GeForce RTX 3070"))
            .SetCorpus(stock.CorpusStock?.First(corpus => corpus.Name == "NZXT H510") ?? throw new ArgumentNullException(nameof(stock)))
            .SetSSD(stock.SSDStock?.First(ssd => ssd.Name == "Samsung 970 EVO Plus 500GB") ?? throw new ArgumentNullException(nameof(stock)))
            .SetCPUCooler(stock.CoolerStock?.First(cooler => cooler.Name == "Noctua NH-D12") ?? throw new ArgumentNullException(nameof(stock)))
            .SetPowerSupply(stock.PowerSupplyStock?.First(powerSupply => powerSupply.Name == "Corsair CX650M") ?? throw new ArgumentNullException(nameof(stock)))
            .Build();
        Assert.Equal(Result.CPUMotherboardConflict, new Validator(pc).Validate());
    }
}
