namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public interface IDamageable
{
    public const double DefaultHealthPoint = 100;
    public double HealthPoints { get; }
    public int MaxAsteroidCollisions { get; }
    public int MaxMeteoriteCollisions { get; }
    public Result TakeDamage(IEnvironment environment);
    public bool IsAlive();
}
