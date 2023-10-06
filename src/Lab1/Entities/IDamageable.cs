namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public interface IDamageable
{
    public int HealthPoints { get; }
    public int MaxAsteroidCollisions { get; }
    public int MaxMeteoriteCollisions { get; }
    public void TakeDamage(IObstacle obstacle);
}
