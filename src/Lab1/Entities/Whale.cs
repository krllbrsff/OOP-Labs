namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public class Whale : IObstacle
{
    public Whale()
    {
    }

    public int Damage { get; }
    public int Quantity { get; private set; }

    public void DecreaseQuantity() => Quantity--;
}
