namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class BIOS
{
    private BIOS() { }
    public string? Type { get; private set; }
    public string? Version { get; private set; }

    public class BIOSBuilder
    {
        private string? type;
        private string? version;

        public BIOSBuilder()
        {
        }

        public BIOSBuilder(BIOS bios)
        {
            type = bios.Type;
            version = bios.Version;
        }

        public BIOSBuilder SetType(string type)
        {
            this.type = type;
            return this;
        }

        public BIOSBuilder SetVersion(string version)
        {
            this.version = version;
            return this;
        }

        public BIOS Build()
        {
            return new BIOS
            {
                Type = type,
                Version = version,
            };
        }
    }
}
