namespace Itmo.ObjectOrientedProgramming.Lab2.Components;
public class GPU
{
    public GPU(string dimensions, int videoMemoryGB, string pcieVersion, string chipFrequency, int powerConsumption)
    {
        Dimensions = dimensions;
        VideoMemoryGB = videoMemoryGB;
        PCIEVersion = pcieVersion;
        ChipFrequency = chipFrequency;
        PowerConsumption = powerConsumption;
    }

    public string Dimensions { get; }
    public int VideoMemoryGB { get; }
    public string PCIEVersion { get; }
    public string ChipFrequency { get; }
    public int PowerConsumption { get; }
}