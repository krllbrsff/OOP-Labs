namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public interface IShip
{
    public IEngine ImpulseEngine { get; }
    public IEngine? JumpEngine { get; }
    public Deflector? Deflector { get; }
    public Corpus Corpus { get; }
}
