namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
internal interface IShip
{
    public IEngine ImpulseEngine { get; }
    public IEngine? JumpEngine { get; }
    public Deflector? Deflector { get; }
    public Corpus Corpus { get; }
}
