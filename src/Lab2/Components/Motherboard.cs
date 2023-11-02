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
            sataPorts = motherboard.SATAPorts;
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
                SATAPorts = sataPorts,
                Chipset = chipset,
                DDRStandard = ddrStandard,
                RamSlots = ramSlots,
                FormFactor = formFactor,
                BIOS = bios,
            };
        }
    }
}
