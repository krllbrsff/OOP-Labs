namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public class Meteorite : IObstacle
{
    public Meteorite(int count)
    {
        Quantity = count;
    }

    public int Quantity { get; private set; }

    public void DecreaseQuantity() => Quantity--;
}
