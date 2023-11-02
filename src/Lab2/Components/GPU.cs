namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class GPU
{
    private GPU() { }
    public string? Name { get; init; }
    public int Height { get; init; }
    public int VideoMemory { get; init; }
    public string? PCIEVersion { get; init; }
    public string? ChipFrequency { get; init; }
    public int EnergyConsumption { get; init; }

    public class GPUBuilder
    {
        private string? name;
        private int height;
        private int videoMemory;
        private string? pcieVersion;
        private string? chipFrequency;
        private int energyConsumption;

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
            energyConsumption = gpu.EnergyConsumption;
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

        public GPUBuilder SetPowerConsumption(int energyConsumption)
        {
            this.energyConsumption = energyConsumption;
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
                EnergyConsumption = energyConsumption,
            };
        }
    }
}
