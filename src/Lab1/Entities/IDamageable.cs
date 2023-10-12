namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public interface IDamageable
{
    protected const int DefaultHealthPoint = 100;
    public int HealthPoints { get; }
    public int MaxAsteroidCollisions { get; }
    public int MaxMeteoriteCollisions { get; }
    public void TakeDamage(IObstacle obstacle);
}
