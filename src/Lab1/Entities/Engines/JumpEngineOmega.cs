﻿using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public class JumpEngineOmega : IEngine
{
    private const int _startFuel = 327;
    private const int _speed = 10;
    private const int _fuelConsumption = 1 / 1;

    public JumpEngineOmega()
    {
        Distance = 0;
        Time = 0;
    }

    public double Fuel { get; private set; } = _startFuel;

    public double Distance { get; private set; }

    public double Time { get; private set; }

    public Result AddDistance(IEnvironment environment)
    {
        environment = environment ?? throw new ArgumentNullException(nameof(environment));
        Distance += environment.Distance;
        AddTime(environment.Distance);
        return SpendFuel(environment.Distance);
    }

    private void AddTime(int distance)
    {
        Time += distance / _speed;
    }

    private Result SpendFuel(int distance)
    {
        Fuel -= distance * Math.Log10(distance) * _fuelConsumption;
        if (Fuel <= 0)
            return new Result().OutOfFuel();
        return new Result();
    }
}
