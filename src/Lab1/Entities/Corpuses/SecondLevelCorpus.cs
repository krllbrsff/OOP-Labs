namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public class SecondLevelCorpus : Corpus
{
    private const int _maxAsteroidCollisions = 5;
    private const int _maxMeteoriteCollisions = 2;
    public SecondLevelCorpus(bool emmiter)
    {
        MaxAsteroidCollisions = _maxAsteroidCollisions;
        MaxMeteoriteCollisions = _maxMeteoriteCollisions;
        HasAntiNitrineEmitter = emmiter;
    }
}
