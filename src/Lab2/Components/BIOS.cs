namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class BIOS
{
    private BIOS() { }
    public string? Type { get; init; }
    public string? Version { get; init; }

    public class BIOSBuilder
    {
        private string? _type;
        private string? _version;

        public BIOSBuilder()
        {
        }

        public BIOSBuilder(BIOS bios)
        {
            _type = bios.Type;
            _version = bios.Version;
        }

        public BIOSBuilder SetType(string type)
        {
            _type = type;
            return this;
        }

        public BIOSBuilder SetVersion(string version)
        {
            _version = version;
            return this;
        }

        public BIOS Build()
        {
            return new BIOS
            {
                Type = _type,
                Version = _version,
            };
        }
    }
}
