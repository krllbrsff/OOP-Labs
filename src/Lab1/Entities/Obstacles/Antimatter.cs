namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public class Antimatter : IObstacle
{
    public Antimatter(int count)
    {
        Quantity = count;
    }

    public int Quantity { get; private set; }

    public void DecreaseQuantity() => Quantity--;
}
