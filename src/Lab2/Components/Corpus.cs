using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class Corpus
{
    private Corpus() { }
    public string? Name { get; init; }
    public int MaxGPUSize { get; init; }
    public Collection<string>? SupportedMotherboardFormats { get; init; }
    public string? Dimensions { get; init; }

    public class CorpusBuilder
    {
        private string? name;
        private int maxGPUSize;
        private Collection<string>? supportedMotherboardFormats;
        private string? dimensions;

        public CorpusBuilder() { }

        public CorpusBuilder(Corpus pcCase)
        {
            name = pcCase.Name;
            maxGPUSize = pcCase.MaxGPUSize;
            supportedMotherboardFormats = pcCase.SupportedMotherboardFormats;
            dimensions = pcCase.Dimensions;
        }

        public CorpusBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public CorpusBuilder SetMaxGPUSize(int maxGPUSize)
        {
            this.maxGPUSize = maxGPUSize;
            return this;
        }

        public CorpusBuilder SetSupportedMotherboardFormats(Collection<string> supportedMotherboardFormats)
        {
            this.supportedMotherboardFormats = supportedMotherboardFormats;
            return this;
        }

        public CorpusBuilder SetDimensions(string dimensions)
        {
            this.dimensions = dimensions;
            return this;
        }

        public Corpus Build()
        {
            return new Corpus
            {
                Name = name,
                MaxGPUSize = maxGPUSize,
                SupportedMotherboardFormats = supportedMotherboardFormats,
                Dimensions = dimensions,
            };
        }
    }
}
