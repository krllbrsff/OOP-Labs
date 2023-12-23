namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public class Deflector2 : Deflector
{
    private const int _maxAsteroidCollisions = 10;
    private const int _maxMeteoriteCollisions = 3;
    private const int _maxWhaleCollisions = 0;
    private const int _photonicDeflectorHP = 3;
    public Deflector2(bool photonicDeflector)
    {
        MaxAsteroidCollisions = _maxAsteroidCollisions;
        MaxMeteoriteCollisions = _maxMeteoriteCollisions;
        MaxWhaleCollisions = _maxWhaleCollisions;
        PhotonicDeflector = photonicDeflector;
        PhotonicDeflectorHP = _photonicDeflectorHP;
    }
}
