using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public abstract class Corpus : IDamageable
{
    public double HealthPoints { get; protected set; } = IDamageable.DefaultHealthPoint;

    public int MaxAsteroidCollisions { get; init; }

    public int MaxMeteoriteCollisions { get; init; }

    public bool HasAntiNitrineEmitter { get; init; }

    public Result TakeDamage(IEnvironment environment)
    {
        environment = environment ?? throw new ArgumentNullException(nameof(environment));

        foreach (IObstacle obstacle in environment.Obstacles)
        {
            while (obstacle.Quantity >= 0)
            {
                switch (obstacle)
                {
                    case Asteroid:
                        HealthPoints -= IDamageable.DefaultHealthPoint / MaxAsteroidCollisions;
                        obstacle.DecreaseQuantity();
                        if (IsAlive()) break;
                        else return new Result().ShipIsDestroyed();

                    case Meteorite:
                        HealthPoints -= IDamageable.DefaultHealthPoint / MaxMeteoriteCollisions;
                        obstacle.DecreaseQuantity();
                        if (IsAlive()) break;
                        else return new Result().ShipIsDestroyed();

                    case Antimatter:
                        return new Result().CrewIsDead();

                    case Whale:
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
