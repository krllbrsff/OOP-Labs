using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal class IncreasedDensityNebulae : IEnvironment
{
    public IncreasedDensityNebulae(int length, Collection<IObstacle> obstacles)
    {
        Obstacles = obstacles;
        Distance = length;
    }

    public int Distance { get; }
    public Collection<IObstacle> Obstacles { get; }

    public Collection<IObstacle> GetCorrectObstacles()
    {
        var obstacles = new Collection<IObstacle>();
        foreach (IObstacle obstacle in Obstacles)
        {
            if (obstacle is Antimatter)
                obstacles.Add(obstacle);
        }

        return obstacles;
    }
}
