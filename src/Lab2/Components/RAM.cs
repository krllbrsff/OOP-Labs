namespace Itmo.ObjectOrientedProgramming.Lab2.Components;
public class RAM
{
    public RAM(int capacityGB, string jedecFrequenciesAndVoltage, string xmpProfiles, string formFactor, string ddrVersion, int powerConsumption)
    {
        CapacityGB = capacityGB;
        JEDECFrequenciesAndVoltage = jedecFrequenciesAndVoltage;
        XMPProfiles = xmpProfiles;
        FormFactor = formFactor;
        DDRVersion = ddrVersion;
        PowerConsumption = powerConsumption;
    }

    public int CapacityGB { get; }
    public string JEDECFrequenciesAndVoltage { get; }
    public string XMPProfiles { get; }
    public string FormFactor { get; }
    public string DDRVersion { get; }
    public int PowerConsumption { get; }
}
