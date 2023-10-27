namespace Itmo.ObjectOrientedProgramming.Lab2.Components;
public class GPU
{
    private GPU(string dimensions, int videoMemoryGB, string pcieVersion, string chipFrequency, int powerConsumption)
    {
        Dimensions = dimensions;
        VideoMemoryGB = videoMemoryGB;
        PCIEVersion = pcieVersion;
        ChipFrequency = chipFrequency;
        PowerConsumption = powerConsumption;
    }

    public string Dimensions { get; }
    public int VideoMemoryGB { get; }
    public string PCIEVersion { get; }
    public string ChipFrequency { get; }
    public int PowerConsumption { get; }

    public class GPUBuilder
    {
        private string dimensions;
        private int videoMemoryGB;
        private string pcieVersion;
        private string chipFrequency;
        private int powerConsumption;

        public GPUBuilder(GPU gpu)
        {
            dimensions = gpu.Dimensions;
            videoMemoryGB = gpu.VideoMemoryGB;
            pcieVersion = gpu.PCIEVersion;
            chipFrequency = gpu.ChipFrequency;
            powerConsumption = gpu.PowerConsumption;
        }

        public GPUBuilder SetDimensions(string dimensions)
        {
            this.dimensions = dimensions;
            return this;
        }

        public GPUBuilder SetVideoMemoryGB(int videoMemoryGB)
        {
            this.videoMemoryGB = videoMemoryGB;
            return this;
        }

        public GPUBuilder SetPCIEVersion(string pcieVersion)
        {
            this.pcieVersion = pcieVersion;
            return this;
        }

        public GPUBuilder SetChipFrequency(string chipFrequency)
        {
            this.chipFrequency = chipFrequency;
            return this;
        }

        public GPUBuilder SetPowerConsumption(int powerConsumption)
        {
            this.powerConsumption = powerConsumption;
            return this;
        }

        public GPU Build()
        {
            return new GPU(dimensions, videoMemoryGB, pcieVersion, chipFrequency, powerConsumption);
        }
    }
}