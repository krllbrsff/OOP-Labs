using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public abstract class Corpus : IDamageable
{
    public int HealthPoints { get; protected set; }

    public int MaxAsteroidCollisions { get; }

    public int MaxMeteoriteCollisions { get; }

    public bool IsAntiNitrineEmitter { get; protected set; }

    public void TakeDamage(IObstacle obstacle)
    {
        switch (obstacle)
        {
            case Asteroid:
                HealthPoints -= IDamageable.DefaultHealthPoint / MaxAsteroidCollisions; break;

            case Meteorite:
                HealthPoints -= IDamageable.DefaultHealthPoint / MaxMeteoriteCollisions; break;

            case Antimatter:
                throw new NotImplementedException();

            case Whale:
                if (HealthPoints > 0)
                    HealthPoints = 0;
                else throw new NotImplementedException(); break;
        }
    }

    public void SetAntiNitrineEmitter()
    {
        IsAntiNitrineEmitter = true;
    }
}
