namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class BIOSBuilder
{
    private string? type;
    private string? supportedCPUs;

    public BIOSBuilder() { }

    public BIOSBuilder(BIOS bios)
    {
        type = bios.Type;
        supportedCPUs = bios.SupportedCPUs;
    }

    public void SetType(string type) => this.type = type;
    public void SetSupportedCPUs(string supportedCPUs) => this.supportedCPUs = supportedCPUs;

    public BIOS Build()
    {
        return new BIOS(type ?? string.Empty, supportedCPUs ?? string.Empty);
    }
}
