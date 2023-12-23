namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public abstract class Deflector : IDamageable
{
    public int MaxAsteroidCollisions { get; init; }

    public int MaxMeteoriteCollisions { get; init; }

    public int MaxWhaleCollisions { get; init; }

    public double HealthPoints { get; protected set; } = IDamageable.DefaultHealthPoint;

    public bool PhotonicDeflector { get; protected set; }
    public int PhotonicDeflectorHP { get; protected set; }

    public Result TakeDamage(IEnvironment environment, IShip ship)
    {
        foreach (IObstacle obstacle in environment.Obstacles)
        {
            if (ship.Corpus.HasAntiNitrineEmitter && environment is NitrineParticlesNebulae) return new Result();

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
                        if (MaxWhaleCollisions > 0)
                        {
                            HealthPoints -= IDamageable.DefaultHealthPoint / MaxWhaleCollisions;
                            obstacle.DecreaseQuantity();

                            if (IsAlive()) break;
                            else return new Result();
                        }
                        else
                        {
                            return new Result();
                        }
                }
            }
        }

        return new Result();
    }

    public bool IsAlive()
    {
        return HealthPoints >= 0;
    }
}
