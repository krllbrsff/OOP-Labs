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
        private string? _name;
        private int _maxGPUSize;
        private Collection<string>? _supportedMotherboardFormats;
        private string? _dimensions;

        public CorpusBuilder() { }

        public CorpusBuilder(Corpus pcCase)
        {
            _name = pcCase.Name;
            _maxGPUSize = pcCase.MaxGPUSize;
            _supportedMotherboardFormats = pcCase.SupportedMotherboardFormats;
            _dimensions = pcCase.Dimensions;
        }

        public CorpusBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public CorpusBuilder SetMaxGPUSize(int maxGPUSize)
        {
            _maxGPUSize = maxGPUSize;
            return this;
        }

        public CorpusBuilder SetSupportedMotherboardFormats(Collection<string> supportedMotherboardFormats)
        {
            _supportedMotherboardFormats = supportedMotherboardFormats;
            return this;
        }

        public CorpusBuilder SetDimensions(string dimensions)
        {
            _dimensions = dimensions;
            return this;
        }

        public Corpus Build()
        {
            return new Corpus
            {
                Name = _name,
                MaxGPUSize = _maxGPUSize,
                SupportedMotherboardFormats = _supportedMotherboardFormats,
                Dimensions = _dimensions,
            };
        }
    }
}
