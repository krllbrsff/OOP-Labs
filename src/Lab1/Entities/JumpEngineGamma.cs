using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal class JumpEngineGamma : IEngine
{
    private const int _startFuel = 1000;
    private const int _fuelConsumption = 1 / 3;

    public JumpEngineGamma()
    {
    }

    public double Fuel { get; private set; } = _startFuel;

    public double Distance { get; private set; }

    public double Time { get; private set; }

    public void AddDistance(int distance)
    {
        Distance += distance;
        AddTime(distance);
        SpendFuel(distance);
    }

    private void AddTime(int distance)
    {
        Time += Math.Log(distance, Math.E);
    }

    private void SpendFuel(int distance)
    {
        Fuel -= distance * _fuelConsumption;
    }
}
