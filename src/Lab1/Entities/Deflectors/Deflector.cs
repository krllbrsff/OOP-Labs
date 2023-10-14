namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public abstract class Deflector : IDamageable
{
    public int MaxAsteroidCollisions { get; init; }

    public int MaxMeteoriteCollisions { get; init; }

    public int MaxWhaleCollisions { get; init; }

    public double HealthPoints { get; protected set; } = IDamageable.DefaultHealthPoint;

    public int PhotonicDeflectorHP { get; protected set; }

    public Result TakeDamage(IEnvironment environment)
    {
        while (environment?.Obstacles?.Quantity >= 0)
        {
            switch (environment?.Obstacles)
            {
                case Asteroid:
                    HealthPoints -= IDamageable.DefaultHealthPoint / MaxAsteroidCollisions;
                    environment.Obstacles.DecreaseQuantity();
                    if (IsAlive())
                    {
                        environment.ObstacleChange();
                        break;
                    }
                    else
                    {
                        return new Result();
                    }

                case Meteorite:
                    HealthPoints -= IDamageable.DefaultHealthPoint / MaxMeteoriteCollisions;
                    environment.Obstacles.DecreaseQuantity();
                    if (IsAlive()) break;
                    else return new Result();

                case Antimatter:
                    if (HasPhotonicDeflector())
                        PhotonicDeflectorHP--;
                    else return new Result().CrewIsDead(); break;

                case Whale:
                    HealthPoints -= IDamageable.DefaultHealthPoint / MaxWhaleCollisions;
                    environment.Obstacles.DecreaseQuantity();
                    if (IsAlive()) break;
                    else return new Result();
            }
        }

        return new Result();
    }

    public void SetPhotonicDeflector()
    {
        PhotonicDeflectorHP = 3;
    }

    public bool IsAlive()
    {
        if (HealthPoints > 0)
            return true;
        else return false;
    }

    public bool HasPhotonicDeflector()
    {
        if (PhotonicDeflectorHP > 0)
            return true;
        else return false;
    }
}
