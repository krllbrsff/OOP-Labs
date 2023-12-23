namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public class Whale : IObstacle
{
    public Whale(int count)
    {
        Quantity = count;
    }

    public int Quantity { get; private set; }

    public void DecreaseQuantity() => Quantity--;
}
