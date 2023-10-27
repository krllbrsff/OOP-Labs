namespace Itmo.ObjectOrientedProgramming.Lab2.Components;
public class BIOS
{
    public BIOS() { }
    public BIOS(string type, string supportedCPUs)
    {
        Type = type;
        SupportedCPUs = supportedCPUs;
    }

    public BIOS(BIOS bios)
    {
        Type = bios.Type;
        SupportedCPUs = bios.SupportedCPUs;
    }

    public string? Type { get; }
    public string? SupportedCPUs { get; }
}
