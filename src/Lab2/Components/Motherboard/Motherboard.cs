namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class Motherboard
{
    public Motherboard(string socket, int pcieLanes, int sataPorts, string chipset, string ddrStandard, int ramSlots, string formFactor, bool xmp, BIOS bios)
    {
        Socket = socket;
        PCIELanes = pcieLanes;
        SataPorts = sataPorts;
        Chipset = chipset;
        DDRStandard = ddrStandard;
        RamSlots = ramSlots;
        FormFactor = formFactor;
        SupportsXMP = xmp;
        BIOS = bios;
    }

    public string? Socket { get; }
    public int PCIELanes { get; }
    public int SataPorts { get; }
    public string? Chipset { get; }
    public string? DDRStandard { get; }
    public int RamSlots { get; }
    public string? FormFactor { get; }
    public bool SupportsXMP { get; }
    public BIOS BIOS { get; }
}
