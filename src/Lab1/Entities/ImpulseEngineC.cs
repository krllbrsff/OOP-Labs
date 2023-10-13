namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal class ImpulseEngineC : IEngine
{
    private const int _startFuel = 1000;
    private const int _speed = 100;
    private const int _fuelConsumption = 1 / 1;

    public ImpulseEngineC()
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
        Time += distance / _speed;
    }

    private void SpendFuel(int distance)
    {
        Fuel -= distance * _fuelConsumption;
        if (Fuel >= 0) return;
        return false;
    }
}
