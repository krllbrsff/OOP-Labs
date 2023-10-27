using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.Components;
public class RAMBuilder
{
    private int capacityGB;
    private string frequency;
    private Collection<XMPProfile> xmpProfiles;
    private string formFactor;
    private string ddrVersion;
    private int powerConsumption;

    public RAMBuilder(RAM ram)
    {
        capacityGB = ram.CapacityGB;
        frequency = ram.JEDECFrequenciesAndVoltage;
        xmpProfiles = ram.XMPProfiles;
        formFactor = ram.FormFactor;
        ddrVersion = ram.DDRVersion;
        powerConsumption = ram.PowerConsumption;
    }

    public RAMBuilder SetCapacityGB(int capacityGB)
    {
        this.capacityGB = capacityGB;
        return this;
    }

    public RAMBuilder SetJEDECFrequenciesAndVoltage(string frequency)
    {
        this.frequency = frequency;
        return this;
    }

    public RAMBuilder SetXMPProfiles(Collection<XMPProfile> xmpProfiles)
    {
        this.xmpProfiles = xmpProfiles;
        return this;
    }

    public RAMBuilder SetFormFactor(string formFactor)
    {
        this.formFactor = formFactor;
        return this;
    }

    public RAMBuilder SetDDRVersion(string ddrVersion)
    {
        this.ddrVersion = ddrVersion;
        return this;
    }

    public RAMBuilder SetPowerConsumption(int powerConsumption)
    {
        this.powerConsumption = powerConsumption;
        return this;
    }

    public RAM Build()
    {
        return new RAM(capacityGB, frequency, xmpProfiles, formFactor, ddrVersion, powerConsumption);
    }
}
