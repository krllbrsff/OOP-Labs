using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public class ImpulseEngineE : IEngine
{
    private const int _startFuel = 100;
    private const double _fuelConsumption = 1 / 1;

    public ImpulseEngineE()
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

        return SpendFuel(environment);
    }

    private void AddTime(int distance)
    {
        Time += Math.Log(distance);
    }

    private Result SpendFuel(IEnvironment environment)
    {
        if (environment is NitrineParticlesNebulae)
            Fuel -= environment.Distance * _fuelConsumption;

        if (Fuel <= 0)
        {
            Fuel = 0;

            return new Result().OutOfFuel();
        }

        SpentFuel = _startFuel - Fuel;

        return new Result();
    }
}
