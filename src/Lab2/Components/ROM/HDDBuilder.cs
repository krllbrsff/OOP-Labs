namespace Itmo.ObjectOrientedProgramming.Lab2.Components;
public class HDDBuilder
{
    private int capacityGB;
    private int spindleSpeed;
    private int powerConsumption;

    public HDDBuilder() { }
    public HDDBuilder(HDD hdd)
    {
        capacityGB = hdd.CapacityGB;
        spindleSpeed = hdd.SpindleSpeed;
        powerConsumption = hdd.PowerConsumption;
    }

    public HDDBuilder SetCapacityGB(int capacityGB)
    {
        this.capacityGB = capacityGB;
        return this;
    }

    public HDDBuilder SetSpindleSpeed(int spindleSpeed)
    {
        this.spindleSpeed = spindleSpeed;
        return this;
    }

    public HDDBuilder SetPowerConsumption(int powerConsumption)
    {
        this.powerConsumption = powerConsumption;
        return this;
    }

    public HDD Build()
    {
        return new HDD(capacityGB, spindleSpeed, powerConsumption);
    }
}
