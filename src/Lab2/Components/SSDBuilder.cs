namespace Itmo.ObjectOrientedProgramming.Lab2.Components;
public class SSDBuilder
{
    private string connectionType;
    private int capacityGB;
    private string maxSpeed;
    private int powerConsumption;

    public SSDBuilder(SSD ssd)
    {
        connectionType = ssd.ConnectionType;
        capacityGB = ssd.CapacityGB;
        maxSpeed = ssd.MaxSpeed;
        powerConsumption = ssd.PowerConsumption;
    }

    public SSDBuilder SetConnectionType(string connectionType)
    {
        this.connectionType = connectionType;
        return this;
    }

    public SSDBuilder SetCapacityGB(int capacityGB)
    {
        this.capacityGB = capacityGB;
        return this;
    }

    public SSDBuilder SetMaxSpeed(string maxSpeed)
    {
        this.maxSpeed = maxSpeed;
        return this;
    }

    public SSDBuilder SetPowerConsumption(int powerConsumption)
    {
        this.powerConsumption = powerConsumption;
        return this;
    }

    public SSD Build()
    {
        return new SSD(connectionType, capacityGB, maxSpeed, powerConsumption);
    }
}
