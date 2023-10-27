namespace Itmo.ObjectOrientedProgramming.Lab2.Components;
public class RAMBuilder
{
    private int capacityGB;
    private string jedecFrequenciesAndVoltage;
    private string xmpProfiles;
    private string formFactor;
    private string ddrVersion;
    private int powerConsumption;

    public RAMBuilder(RAM ram)
    {
        capacityGB = ram.CapacityGB;
        jedecFrequenciesAndVoltage = ram.JEDECFrequenciesAndVoltage;
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

    public RAMBuilder SetJEDECFrequenciesAndVoltage(string jedecFrequenciesAndVoltage)
    {
        this.jedecFrequenciesAndVoltage = jedecFrequenciesAndVoltage;
        return this;
    }

    public RAMBuilder SetXMPProfiles(string xmpProfiles)
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
        return new RAM(capacityGB, jedecFrequenciesAndVoltage, xmpProfiles, formFactor, ddrVersion, powerConsumption);
    }
}
