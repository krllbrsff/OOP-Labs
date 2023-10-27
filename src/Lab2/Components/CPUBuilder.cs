using System;
using Itmo.ObjectOrientedProgramming.Lab2.Components;
namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;
public class CPUBuilder
{
    public CPUBuilder(CPU cpu)
    {
        if (cpu == null) throw new ArgumentNullException(nameof(cpu));

        Name = cpu.Name;
        CoreCount = cpu.CoreCount;
        CoreFrequency = cpu.CoreFrequency;
        IntegratedGraphics = cpu.IntegratedGraphics;
        Socket = cpu.Socket;
        ROMFrequencies = cpu.ROMFrequencies;
        TDP = cpu.TDP;
        EnergyConsumption = cpu.EnergyConsumption;
    }

    private string? Name { get; set; }
    private string Socket { get; set; }
    private bool IntegratedGraphics { get; set; }
    private int CoreCount { get; set; }
    private double CoreFrequency { get; set; }
    private string ROMFrequencies { get; set; }
    private int TDP { get; set; }
    private int EnergyConsumption { get; set; }

    public void SetName(string name) => Name = name;

    public void SetCoreFrequency(double frequency) => CoreFrequency = frequency;

    public void SetCores(int cores) => CoreCount = cores;

    public void SetSocket(string socket) => Socket = socket;

    public void AddIntegratedGraphics() => IntegratedGraphics = true;

    public void RemoveIntegratedGraphics() => IntegratedGraphics = false;

    public void SetROMFrequencies(string romFrequencies) => ROMFrequencies = romFrequencies;

    public void SetTDP(int tdp) => TDP = tdp;

    public void SetEnergyConsumption(int energyConsumption) => EnergyConsumption = energyConsumption;

    public CPU Build()
    {
        if (Name == null) throw new ArgumentNullException(nameof(CPUBuilder));

        return new CPU(Name, CoreCount, CoreFrequency, Socket, ROMFrequencies, TDP, EnergyConsumption);
    }
}
