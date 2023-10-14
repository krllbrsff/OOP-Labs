namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public abstract class Corpus : IDamageable
{
    public double HealthPoints { get; protected set; } = IDamageable.DefaultHealthPoint;

    public int MaxAsteroidCollisions { get; init; }

    public int MaxMeteoriteCollisions { get; init; }

    public bool HasAntiNitrineEmitter { get; init; }

    public Result TakeDamage(IEnvironment environment)
    {
        while (environment?.Obstacles?.Quantity > 0)
        {
            switch (environment.Obstacles)
            {
                case Asteroid _:
                    HealthPoints -= IDamageable.DefaultHealthPoint / MaxAsteroidCollisions;
                    environment.Obstacles.DecreaseQuantity();
                    if (IsAlive())
                    {
                        environment.ObstacleChange();
                        break;
                    }
                    else
                    {
                        return new Result().ShipIsDestroyed();
                    }

                case Meteorite _:
                    HealthPoints -= IDamageable.DefaultHealthPoint / MaxMeteoriteCollisions;
                    environment.Obstacles.DecreaseQuantity();
                    if (IsAlive()) break;
                    else return new Result().ShipIsDestroyed();

                case Antimatter:
                    return new Result().CrewIsDead();

                case Whale:
                    if (HasAntiNitrineEmitter)
                    {
                        environment.Obstacles.DecreaseQuantity();
                        break;
                    }
                    else
                    {
                        return new Result().ShipIsDestroyed();
                    }
            }
        }

        return new Result();
    }

    public bool IsAlive()
    {
        if (HealthPoints > 0)
            return true;
        else return false;
    }
}
