using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public abstract class Deflector : IDamageable
{
    public int MaxAsteroidCollisions { get; init; }

    public int MaxMeteoriteCollisions { get; init; }

    public int HealthPoints { get; protected set; } = IDamageable.DefaultHealthPoint;

    public int PhotonicDeflectorHP { get; protected set; }

    public void TakeDamage(IObstacle obstacle)
    {
        switch (obstacle)
        {
            case Asteroid _:
                HealthPoints -= IDamageable.DefaultHealthPoint / MaxAsteroidCollisions * obstacle.Quantity; break;

            case Meteorite _:
                HealthPoints -= IDamageable.DefaultHealthPoint / MaxMeteoriteCollisions * obstacle.Quantity; break;

            case Antimatter:
                if (PhotonicDeflectorHP > 0)
                    PhotonicDeflectorHP--;
                else throw new NotImplementedException(); break;

            case Whale:
                if (HealthPoints > 0)
                    HealthPoints = 0;
                else throw new NotImplementedException(); break;
        }
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
}
