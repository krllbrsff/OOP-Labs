namespace Itmo.ObjectOrientedProgramming.Lab2.Components;
public class CPU
{
    public CPU(string name, int coreCount, double coreFrequency, string socket, string romFrequencies, int tdp, int energyConsumption)
    {
        Name = name;
        CoreCount = coreCount;
        CoreFrequency = coreFrequency;
        Socket = socket;
        ROMFrequencies = romFrequencies;
        TDP = tdp;
        EnergyConsumption = energyConsumption;
    }

    public string? Name { get; }
    public string? Socket { get; }
    public bool IntegratedGraphics { get; }
    public int CoreCount { get; }
    public double CoreFrequency { get; }
    public string? ROMFrequencies { get; }
    public int TDP { get; }
    public int EnergyConsumption { get; }
}