using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public class ImpulseEngineC : IEngine
{
    private const int _startFuel = 100;
    private const int _speed = 10;
    private const double _fuelConsumption = 0.5;

    public ImpulseEngineC()
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
        environment = environment ?? throw new ArgumentNullException(nameof(environment));
        Distance += environment.Distance;
        AddTime(environment.Distance);
        return SpendFuel(environment);
    }

    private void AddTime(int distance)
    {
        Time += distance / _speed;
    }

    private Result SpendFuel(IEnvironment environment)
    {
        if (environment is NitrineParticlesNebulae)
            Fuel -= environment.Distance * _fuelConsumption * 4;
        else Fuel -= environment.Distance * _fuelConsumption;
        if (Fuel <= 0)
        {
            Fuel = 0;
            return new Result().OutOfFuel();
        }

        SpentFuel = _startFuel - Fuel;
        return new Result();
    }
}
