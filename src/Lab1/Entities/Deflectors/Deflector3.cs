namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public class Deflector3 : Deflector
{
    private const int _maxAsteroidCollisions = 40;
    private const int _maxMeteoriteCollisions = 10;
    private const int _maxWhaleCollisions = 1;
    public Deflector3()
    {
        MaxAsteroidCollisions = _maxAsteroidCollisions;
        MaxMeteoriteCollisions = _maxMeteoriteCollisions;
        MaxWhaleCollisions = _maxWhaleCollisions;
    }
}
