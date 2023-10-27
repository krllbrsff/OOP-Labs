namespace Itmo.ObjectOrientedProgramming.Lab2.Components;
public class HDD
{
    public HDD(int capacityGB, int spindleSpeed, int powerConsumption)
    {
        CapacityGB = capacityGB;
        SpindleSpeed = spindleSpeed;
        PowerConsumption = powerConsumption;
    }

    public int CapacityGB { get; }
    public int SpindleSpeed { get; }
    public int PowerConsumption { get; }
}
