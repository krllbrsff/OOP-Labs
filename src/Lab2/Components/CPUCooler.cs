namespace Itmo.ObjectOrientedProgramming.Lab2.Components;
public class CPUCooler
{
    public CPUCooler(string dimensions, string supportedSockets, int maxTDP)
    {
        Dimensions = dimensions;
        SupportedSockets = supportedSockets;
        MaxTDP = maxTDP;
    }

    public string Dimensions { get; }
    public string SupportedSockets { get; }
    public int MaxTDP { get; }
}
