using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public abstract class Deflector : IDamageable
{
    public int MaxAsteroidCollisions { get; init; }

    public int MaxMeteoriteCollisions { get; init; }

    public int MaxWhaleCollisions { get; init; }

    public double HealthPoints { get; protected set; } = IDamageable.DefaultHealthPoint;

    public bool PhotonicDeflector { get; protected set; }
    public int PhotonicDeflectorHP { get; protected set; }

    public Result TakeDamage(IEnvironment environment)
    {
        environment = environment ?? throw new ArgumentNullException(nameof(environment));

        foreach (IObstacle obstacle in environment.Obstacles)
        {
            while (obstacle.Quantity > 0)
            {
                switch (obstacle)
                {
                    case Asteroid:
                        HealthPoints -= IDamageable.DefaultHealthPoint / MaxAsteroidCollisions;
                        obstacle.DecreaseQuantity();
                        if (IsAlive()) break;
                        else return new Result();

                    case Meteorite:
                        HealthPoints -= IDamageable.DefaultHealthPoint / MaxMeteoriteCollisions;
                        obstacle.DecreaseQuantity();
                        if (IsAlive()) break;
                        else return new Result();

                    case Antimatter:
                        if (PhotonicDeflector)
                        {
                            PhotonicDeflectorHP--;
                            break;
                        }
                        else
                        {
                            return new Result().CrewIsDead();
                        }

                    case Whale:
                        HealthPoints -= IDamageable.DefaultHealthPoint / MaxWhaleCollisions;
                        obstacle.DecreaseQuantity();
                        if (IsAlive()) break;
                        else return new Result();
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
