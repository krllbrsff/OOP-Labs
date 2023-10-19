using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal class OpenSpace : IEnvironment
{
    public OpenSpace(int length, Collection<IObstacle> obstacles)
    {
        Obstacles = GetCorrectObstacles(obstacles);
        Distance = length;
    }

    public int Distance { get; }
    public Collection<IObstacle> Obstacles { get; }

    public Collection<IObstacle> GetCorrectObstacles(Collection<IObstacle> obstacles)
    {
        var correctObstacles = new Collection<IObstacle>();
        foreach (IObstacle obstacle in obstacles)
        {
            if (obstacle is Asteroid or Meteorite)
                correctObstacles.Add(obstacle);
        }

        return correctObstacles;
    }
}
