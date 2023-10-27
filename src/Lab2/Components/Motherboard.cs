using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class Motherboard
{
    public Motherboard(string socket, int pcieLanes, int sataPorts, string chipset, string ddrStandard, int ramSlots, string formFactor, string biosType, string biosVersion)
    {
        Socket = socket;
        PCIELanes = pcieLanes;
        SataPorts = sataPorts;
        Chipset = chipset;
        DDRStandard = ddrStandard;
        RamSlots = ramSlots;
        FormFactor = formFactor;
        BiosType = biosType;
        BiosVersion = biosVersion;
    }

    public string Socket { get; }
    public int PCIELanes { get; }
    public int SataPorts { get; }
    public string Chipset { get; }
    public string DDRStandard { get; }
    public int RamSlots { get; }
    public string FormFactor { get; }
    public string BiosType { get; }
    public string BiosVersion { get; }
}
