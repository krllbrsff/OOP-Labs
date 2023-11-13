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
        private string? _name;
        private Collection<int>? _memoryFrequencies;
        private bool _xmp;

        public ChipsetBuilder()
        {
        }

        public ChipsetBuilder(Chipset chipset)
        {
            _name = chipset.Name;
            _memoryFrequencies = chipset.MemoryFrequencies;
            _xmp = chipset.XMP;
        }

        public ChipsetBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public ChipsetBuilder AddMemoryFrequency(int frequency)
        {
            _memoryFrequencies?.Add(frequency);
            return this;
        }

        public ChipsetBuilder WithXMPSupport()
        {
            _xmp = true;
            return this;
        }

        public ChipsetBuilder WithoutXMPSupport()
        {
            _xmp = false;
            return this;
        }

        public Chipset Build()
        {
            return new Chipset
            {
                Name = _name,
                MemoryFrequencies = _memoryFrequencies,
                XMP = _xmp,
            };
        }
    }
}
