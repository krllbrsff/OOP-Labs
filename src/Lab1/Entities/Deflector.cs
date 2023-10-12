﻿using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public abstract class Deflector : IDamageable
{
    public int MaxAsteroidCollisions { get; }

    public int MaxMeteoriteCollisions { get; }

    public int HealthPoints { get; protected set; } = IDamageable.DefaultHealthPoint;

    public int PhotonicDeflectorHP { get; protected set; }

    public void TakeDamage(IObstacle obstacle)
    {
        switch (obstacle)
        {
            case Asteroid:
                HealthPoints -= IDamageable.DefaultHealthPoint / MaxAsteroidCollisions; break;

            case Meteorite:
                HealthPoints -= IDamageable.DefaultHealthPoint / MaxMeteoriteCollisions; break;

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
}
