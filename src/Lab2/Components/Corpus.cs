namespace Itmo.ObjectOrientedProgramming.Lab2.Components;
public class Corpus
{
    private Corpus(string maxGPUSize, string supportedMotherboardFormats, string dimensions)
    {
        MaxGPUSize = maxGPUSize;
        SupportedMotherboardFormats = supportedMotherboardFormats;
        Dimensions = dimensions;
    }

    public string MaxGPUSize { get; }
    public string SupportedMotherboardFormats { get; }
    public string Dimensions { get; }

    public class CorpusBuilder
    {
        private string maxGPUSize;
        private string supportedMotherboardFormats;
        private string dimensions;

        public CorpusBuilder(Corpus pcCase)
        {
            maxGPUSize = pcCase.MaxGPUSize;
            supportedMotherboardFormats = pcCase.SupportedMotherboardFormats;
            dimensions = pcCase.Dimensions;
        }

        public CorpusBuilder SetMaxGPUSize(string maxGPUSize)
        {
            this.maxGPUSize = maxGPUSize;
            return this;
        }

        public CorpusBuilder SetSupportedMotherboardFormats(string supportedMotherboardFormats)
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
            return new Corpus(maxGPUSize, supportedMotherboardFormats, dimensions);
        }
    }
}