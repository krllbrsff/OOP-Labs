namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public interface IEnvironment
{
    public int Distance { get; }
    public IObstacle? Obstacles { get; }

    public void ObstacleChange();
}
