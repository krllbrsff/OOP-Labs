namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class GPU
{
    private GPU() { }
    public string? Name { get; private set; }
    public int Height { get; private set; }
    public int VideoMemory { get; private set; }
    public string? PCIEVersion { get; private set; }
    public string? ChipFrequency { get; private set; }
    public int PowerConsumption { get; private set; }

    public class GPUBuilder
    {
        private string? name;
        private int height;
        private int videoMemory;
        private string? pcieVersion;
        private string? chipFrequency;
        private int powerConsumption;

        public GPUBuilder()
        {
        }

        public GPUBuilder(GPU gpu)
        {
            name = gpu.Name;
            height = gpu.Height;
            videoMemory = gpu.VideoMemory;
            pcieVersion = gpu.PCIEVersion;
            chipFrequency = gpu.ChipFrequency;
            powerConsumption = gpu.PowerConsumption;
        }

        public GPUBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public GPUBuilder SetHeight(int height)
        {
            this.height = height;
            return this;
        }

        public GPUBuilder SetVideoMemory(int videoMemory)
        {
            this.videoMemory = videoMemory;
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
            return new GPU
            {
                Name = name,
                Height = height,
                VideoMemory = videoMemory,
                PCIEVersion = pcieVersion,
                ChipFrequency = chipFrequency,
                PowerConsumption = powerConsumption,
            };
        }
    }
}
