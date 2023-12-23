namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class Motherboard
{
    private Motherboard() { }
    public string? Name { get; init; }
    public string? Socket { get; init; }
    public int PCIELines { get; init; }
    public int SATAPorts { get; init; }
    public Chipset? Chipset { get; init; }
    public string? DDRStandard { get; init; }
    public int RamSlots { get; init; }
    public string? FormFactor { get; init; }
    public BIOS? BIOS { get; init; }

    public class MotherboardBuilder
    {
        private string? _name;
        private string? _socket;
        private int _pcieLines;
        private int _sataPorts;
        private Chipset? _chipset;
        private string? _ddrStandard;
        private int _ramSlots;
        private string? _formFactor;
        private BIOS? _bios;

        public MotherboardBuilder()
        {
        }

        public MotherboardBuilder(Motherboard motherboard)
        {
            _name = motherboard.Name;
            _socket = motherboard.Socket;
            _pcieLines = motherboard.PCIELines;
            _sataPorts = motherboard.SATAPorts;
            _chipset = motherboard.Chipset;
            _ddrStandard = motherboard.DDRStandard;
            _ramSlots = motherboard.RamSlots;
            _formFactor = motherboard.FormFactor;
            _bios = motherboard.BIOS;
        }

        public MotherboardBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public MotherboardBuilder SetSocket(string socket)
        {
            _socket = socket;
            return this;
        }

        public MotherboardBuilder SetPCIELines(int pcieLines)
        {
            _pcieLines = pcieLines;
            return this;
        }

        public MotherboardBuilder SetSataPorts(int sataPorts)
        {
            _sataPorts = sataPorts;
            return this;
        }

        public MotherboardBuilder SetChipset(Chipset? chipset)
        {
            _chipset = chipset;
            return this;
        }

        public MotherboardBuilder SetDDRStandard(string ddrStandard)
        {
            _ddrStandard = ddrStandard;
            return this;
        }

        public MotherboardBuilder SetRamSlots(int ramSlots)
        {
            _ramSlots = ramSlots;
            return this;
        }

        public MotherboardBuilder SetFormFactor(string formFactor)
        {
            _formFactor = formFactor;
            return this;
        }

        public MotherboardBuilder SetBIOS(BIOS? bios)
        {
            _bios = bios;
            return this;
        }

        public Motherboard Build()
        {
            return new Motherboard
            {
                Name = _name,
                Socket = _socket,
                PCIELines = _pcieLines,
                SATAPorts = _sataPorts,
                Chipset = _chipset,
                DDRStandard = _ddrStandard,
                RamSlots = _ramSlots,
                FormFactor = _formFactor,
                BIOS = _bios,
            };
        }
    }
}
