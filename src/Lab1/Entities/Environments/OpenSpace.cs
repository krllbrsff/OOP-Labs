namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal class OpenSpace : IEnvironment
{
    public OpenSpace(int length, int asteroidsCount, int meteoritesCount)
    {
        Asteroid = new Asteroid(asteroidsCount);
        Meteorite = new Meteorite(meteoritesCount);
        Distance = length;
        Obstacles = null;
        Obstacles = Asteroid;
    }

    public int AsteroidsCount { get; }
    public int MeteoritesCount { get; }
    public int Distance { get; }
    public IObstacle Asteroid { get; }
    public IObstacle Meteorite { get; }
    public IObstacle? Obstacles { get; private set; }

    public void ObstacleChange()
    {
        if (Obstacles?.Quantity == 0)
        Obstacles = Meteorite;
    }
}
