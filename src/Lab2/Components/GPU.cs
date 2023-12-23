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
        private string? _name;
        private int _height;
        private int _videoMemory;
        private string? _pcieVersion;
        private string? _chipFrequency;
        private int _energyConsumption;

        public GPUBuilder()
        {
        }

        public GPUBuilder(GPU gpu)
        {
            _name = gpu.Name;
            _height = gpu.Height;
            _videoMemory = gpu.VideoMemory;
            _pcieVersion = gpu.PCIEVersion;
            _chipFrequency = gpu.ChipFrequency;
            _energyConsumption = gpu.EnergyConsumption;
        }

        public GPUBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public GPUBuilder SetHeight(int height)
        {
            _height = height;
            return this;
        }

        public GPUBuilder SetVideoMemory(int videoMemory)
        {
            _videoMemory = videoMemory;
            return this;
        }

        public GPUBuilder SetPCIEVersion(string pcieVersion)
        {
            _pcieVersion = pcieVersion;
            return this;
        }

        public GPUBuilder SetChipFrequency(string chipFrequency)
        {
            _chipFrequency = chipFrequency;
            return this;
        }

        public GPUBuilder SetPowerConsumption(int energyConsumption)
        {
            _energyConsumption = energyConsumption;
            return this;
        }

        public GPU Build()
        {
            return new GPU
            {
                Name = _name,
                Height = _height,
                VideoMemory = _videoMemory,
                PCIEVersion = _pcieVersion,
                ChipFrequency = _chipFrequency,
                EnergyConsumption = _energyConsumption,
            };
        }
    }
}
