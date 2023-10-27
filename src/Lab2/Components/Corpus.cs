namespace Itmo.ObjectOrientedProgramming.Lab2.Components;
public class Corpus
{
    public Corpus(string maxGPUSize, string supportedMotherboardFormats, string dimensions)
    {
        MaxGPUSize = maxGPUSize;
        SupportedMotherboardFormats = supportedMotherboardFormats;
        Dimensions = dimensions;
    }

    public string MaxGPUSize { get; }
    public string SupportedMotherboardFormats { get; }
    public string Dimensions { get; }
}