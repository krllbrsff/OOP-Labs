namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public class Deflector1 : Deflector
{
    private const int _maxAsteroidCollisions = 2;
    private const int _maxMeteoriteCollisions = 1;
    private const int _maxWhaleCollisions = 0;
    private const int _photonicDeflectorHP = 3;
    public Deflector1(bool photonicDeflector)
    {
        MaxAsteroidCollisions = _maxAsteroidCollisions;
        MaxMeteoriteCollisions = _maxMeteoriteCollisions;
        MaxWhaleCollisions = _maxWhaleCollisions;
        PhotonicDeflector = photonicDeflector;
        PhotonicDeflectorHP = _photonicDeflectorHP;
    }
}
