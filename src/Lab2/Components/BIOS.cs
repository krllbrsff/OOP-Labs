namespace Itmo.ObjectOrientedProgramming.Lab2.Components;
public class BIOS
{
    private BIOS(string type, string supportedCPUs)
    {
        Type = type;
        SupportedCPUs = supportedCPUs;
    }

    public string? Type { get; }
    public string? SupportedCPUs { get; }

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

        public BIOSBuilder SetType(string type)
        {
            this.type = type;
            return this;
        }

        public BIOSBuilder SetSupportedCPUs(string supportedCPUs)
        {
            this.supportedCPUs = supportedCPUs;
            return this;
        }

        public BIOS Build()
        {
            return new BIOS(type ?? string.Empty, supportedCPUs ?? string.Empty);
        }
    }
}
