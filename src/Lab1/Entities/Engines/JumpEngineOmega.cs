using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public class JumpEngineOmega : IEngine
{
    private const int _startFuel = 327;
    private const int _speed = 10;
    private const double _fuelConsumption = 1 / 1;

    public JumpEngineOmega()
    {
        Distance = 0;
        Time = 0;
    }

    public double Fuel { get; private set; } = _startFuel;
    public double SpentFuel { get; private set; }
    public double Distance { get; private set; }
    public double Time { get; private set; }

    public Result AddDistance(IEnvironment environment)
    {
        Distance += environment.Distance;

        AddTime(environment.Distance);

        Result? result = SpendFuel(environment.Distance);

        return result;
    }

    private void AddTime(int distance)
    {
        Time += distance / _speed;
    }

    private Result SpendFuel(int distance)
    {
        Fuel -= distance * Math.Log10(distance) * _fuelConsumption;

        if (Fuel <= 0)
        {
            Fuel = 0;

            return new Result().OutOfFuel();
        }

        SpentFuel = _startFuel - Fuel;

        return new Result();
    }
}
