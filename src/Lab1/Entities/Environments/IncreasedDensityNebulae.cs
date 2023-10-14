namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal class IncreasedDensityNebulae : IEnvironment
{
    public IncreasedDensityNebulae(int length, int antiMatterCount)
    {
        Obstacles = new Antimatter(antiMatterCount);
        Distance = length;
    }

    public int AntiMatterCount { get; }
    public int Distance { get; }
    public IObstacle Obstacles { get; }

    public void ObstacleChange() { }
}
