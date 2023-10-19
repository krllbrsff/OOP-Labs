namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public abstract class Corpus : IDamageable
{
    public double HealthPoints { get; protected set; } = IDamageable.DefaultHealthPoint;

    public int MaxAsteroidCollisions { get; init; }

    public int MaxMeteoriteCollisions { get; init; }

    public bool HasAntiNitrineEmitter { get; init; }

    public Result TakeDamage(IEnvironment environment, IShip ship)
    {
        foreach (IObstacle obstacle in environment.Obstacles)
        {
            while (obstacle.Quantity > 0)
            {
                if (HasAntiNitrineEmitter && environment is NitrineParticlesNebulae) return new Result();

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
        return HealthPoints >= 0;
    }
}
