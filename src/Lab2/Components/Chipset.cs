using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class Chipset
{
    private Chipset() { }
    public string? Name { get; init; }
    public Collection<int>? MemoryFrequencies { get; init; }
    public bool XMP { get; init; }

    public class ChipsetBuilder
    {
        private string? name;
        private Collection<int>? memoryFrequencies;
        private bool xmp;

        public ChipsetBuilder()
        {
        }

        public ChipsetBuilder(Chipset chipset)
        {
            name = chipset.Name;
            memoryFrequencies = chipset.MemoryFrequencies;
            xmp = chipset.XMP;
        }

        public ChipsetBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public ChipsetBuilder AddMemoryFrequency(int frequency)
        {
            memoryFrequencies?.Add(frequency);
            return this;
        }

        public ChipsetBuilder WithXMPSupport()
        {
            xmp = true;
            return this;
        }

        public ChipsetBuilder WithoutXMPSupport()
        {
            xmp = false;
            return this;
        }

        public Chipset Build()
        {
            return new Chipset
            {
                Name = name,
                MemoryFrequencies = memoryFrequencies,
                XMP = xmp,
            };
        }
    }
}
