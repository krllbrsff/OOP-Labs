namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public class Deflector1 : Deflector
{
    private const int _maxAsteroidCollisions = 2;
    private const int _maxMeteoriteCollisions = 1;
    private const int _maxWhaleCollisions = 0;
    public Deflector1()
    {
        MaxAsteroidCollisions = _maxAsteroidCollisions;
        MaxMeteoriteCollisions = _maxMeteoriteCollisions;
        MaxWhaleCollisions = _maxWhaleCollisions;
    }
}
