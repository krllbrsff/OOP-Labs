namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public class Deflector3 : Deflector
{
    private const int _maxAsteroidCollisions = 40;
    private const int _maxMeteoriteCollisions = 10;
    private const int _maxWhaleCollisions = 1;
    private const int _photonicDeflectorHP = 3;
    public Deflector3(bool photonicDeflector)
    {
        MaxAsteroidCollisions = _maxAsteroidCollisions;
        MaxMeteoriteCollisions = _maxMeteoriteCollisions;
        MaxWhaleCollisions = _maxWhaleCollisions;
        PhotonicDeflector = photonicDeflector;
        PhotonicDeflectorHP = _photonicDeflectorHP;
    }
}
