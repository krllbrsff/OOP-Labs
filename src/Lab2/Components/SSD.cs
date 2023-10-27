namespace Itmo.ObjectOrientedProgramming.Lab2.Components;
public class SSD
{
    public SSD(string connectionType, int capacityGB, string maxSpeed, int powerConsumption)
    {
        ConnectionType = connectionType;
        CapacityGB = capacityGB;
        MaxSpeed = maxSpeed;
        PowerConsumption = powerConsumption;
    }

    public string ConnectionType { get; }
    public int CapacityGB { get; }
    public string MaxSpeed { get; }
    public int PowerConsumption { get; }
}