namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public interface IDamageable
{
    protected const int DefaultHealthPoint = 100;
    public int HealthPoints { get; }
    public int MaxAsteroidCollisions { get; init; }
    public int MaxMeteoriteCollisions { get; init; }
    public void TakeDamage(IObstacle obstacle);
    public bool IsAlive();
}
