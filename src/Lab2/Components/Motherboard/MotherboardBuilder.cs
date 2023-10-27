namespace Itmo.ObjectOrientedProgramming.Lab2.Components;
public class MotherboardBuilder
{
    private string? socket;
    private int pcieLanes;
    private int sataPorts;
    private string? chipset;
    private string? ddrStandard;
    private int ramSlots;
    private string? formFactor;
    private bool supportsXMP;
    private BIOS bios;

    public MotherboardBuilder(Motherboard motherboard)
    {
        socket = motherboard.Socket;
        pcieLanes = motherboard.PCIELanes;
        sataPorts = motherboard.SataPorts;
        chipset = motherboard.Chipset;
        ddrStandard = motherboard.DDRStandard;
        ramSlots = motherboard.RamSlots;
        formFactor = motherboard.FormFactor;
        bios = motherboard.BIOS;
        supportsXMP = motherboard.SupportsXMP;
    }

    public MotherboardBuilder SetSocket(string socket)
    {
        this.socket = socket;
        return this;
    }

    public MotherboardBuilder SetPCIELanes(int pcieLanes)
    {
        this.pcieLanes = pcieLanes;
        return this;
    }

    public MotherboardBuilder SetSataPorts(int sataPorts)
    {
        this.sataPorts = sataPorts;
        return this;
    }

    public MotherboardBuilder SetChipset(string chipset)
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

    public MotherboardBuilder SetBIOS(BIOS bios)
    {
        this.bios = bios;
        return this;
    }

    public Motherboard Build()
    {
        return new Motherboard(socket ?? string.Empty, pcieLanes, sataPorts, chipset ?? string.Empty, ddrStandard ?? string.Empty, ramSlots, formFactor ?? string.Empty, supportsXMP, bios);
    }
}