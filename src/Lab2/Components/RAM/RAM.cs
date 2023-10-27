using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.Components;
public class RAM
{
    public RAM(int capacityGB, string jedecFrequenciesAndVoltage, Collection<XMPProfile> xmpProfiles, string formFactor, string ddrVersion, int powerConsumption)
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
    public Collection<XMPProfile> XMPProfiles { get; }
    public string FormFactor { get; }
    public string DDRVersion { get; }
    public int PowerConsumption { get; }
}
