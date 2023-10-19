using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public abstract class Corpus : IDamageable
{
    public double HealthPoints { get; protected set; } = IDamageable.DefaultHealthPoint;

    public int MaxAsteroidCollisions { get; init; }

    public int MaxMeteoriteCollisions { get; init; }

    public bool HasAntiNitrineEmitter { get; init; }

    public Result TakeDamage(IEnvironment environment, IShip ship)
    {
        environment = environment ?? throw new ArgumentNullException(nameof(environment));
        var result = new Result();

        foreach (IObstacle obstacle in environment.Obstacles)
        {
            while (obstacle.Quantity > 0)
            {
                if (HasAntiNitrineEmitter && environment is NitrineParticlesNebulae) return result;

                switch (obstacle)
                {
                    case Asteroid:
                        HealthPoints -= IDamageable.DefaultHealthPoint / MaxAsteroidCollisions;
                        obstacle.DecreaseQuantity();
                        if (IsAlive()) break;
                        else return result.ShipIsDestroyed();

                    case Meteorite:
                        HealthPoints -= IDamageable.DefaultHealthPoint / MaxMeteoriteCollisions;
                        obstacle.DecreaseQuantity();
                        if (IsAlive()) break;
                        else return result.ShipIsDestroyed();

                    case Antimatter:
                        return result.CrewIsDead();

                    case Whale:
                        return result.ShipIsDestroyed();
                }
            }
        }

        return result;
    }

    public bool IsAlive()
    {
        if (HealthPoints >= 0)
            return true;
        else return false;
    }
}
