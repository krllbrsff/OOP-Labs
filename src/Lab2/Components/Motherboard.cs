namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class Motherboard
{
    private Motherboard() { }
    public string? Name { get; private set; }
    public string? Socket { get; private set; }
    public int PCIELines { get; private set; }
    public int SataPorts { get; private set; }
    public Chipset? Chipset { get; private set; }
    public string? DDRStandard { get; private set; }
    public int RamSlots { get; private set; }
    public string? FormFactor { get; private set; }
    public BIOS? BIOS { get; private set; }

    public class MotherboardBuilder
    {
        private string? name;
        private string? socket;
        private int pcieLines;
        private int sataPorts;
        private Chipset? chipset;
        private string? ddrStandard;
        private int ramSlots;
        private string? formFactor;
        private BIOS? bios;

        public MotherboardBuilder()
        {
        }

        public MotherboardBuilder(Motherboard motherboard)
        {
            name = motherboard.Name;
            socket = motherboard.Socket;
            pcieLines = motherboard.PCIELines;
            sataPorts = motherboard.SataPorts;
            chipset = motherboard.Chipset;
            ddrStandard = motherboard.DDRStandard;
            ramSlots = motherboard.RamSlots;
            formFactor = motherboard.FormFactor;
            bios = motherboard.BIOS;
        }

        public MotherboardBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public MotherboardBuilder SetSocket(string socket)
        {
            this.socket = socket;
            return this;
        }

        public MotherboardBuilder SetPCIELines(int pcieLines)
        {
            this.pcieLines = pcieLines;
            return this;
        }

        public MotherboardBuilder SetSataPorts(int sataPorts)
        {
            this.sataPorts = sataPorts;
            return this;
        }

        public MotherboardBuilder SetChipset(Chipset? chipset)
        {
            this.chipset = chipset;
            return this;
        }

        public MotherboardBuilder SetDDRStandard(string ddrStandard)
        {
            this.ddrStandard = ddrStandard;
            return this;
        }

        public MotherboardBuilder SetRamSlots(int ramSlots)
        {
            this.ramSlots = ramSlots;
            return this;
        }

        public MotherboardBuilder SetFormFactor(string formFactor)
        {
            this.formFactor = formFactor;
            return this;
        }

        public MotherboardBuilder SetBIOS(BIOS? bios)
        {
            this.bios = bios;
            return this;
        }

        public Motherboard Build()
        {
            return new Motherboard
            {
                Name = name,
                Socket = socket,
                PCIELines = pcieLines,
                SataPorts = sataPorts,
                Chipset = chipset,
                DDRStandard = ddrStandard,
                RamSlots = ramSlots,
                FormFactor = formFactor,
                BIOS = bios,
            };
        }
    }
}
