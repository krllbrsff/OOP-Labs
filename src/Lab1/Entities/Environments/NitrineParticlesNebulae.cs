namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal class NitrineParticlesNebulae : IEnvironment
{
    public NitrineParticlesNebulae(int length, int whalesCount)
    {
        Obstacles = new Whale(whalesCount);
        Distance = length;
    }

    public int Distance { get; }
    public int WhalesCount { get; }
    public IObstacle Obstacles { get; }

    public void ObstacleChange() { }
}
