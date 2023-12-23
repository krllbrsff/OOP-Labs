namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public class Asteroid : IObstacle
{
    public Asteroid(int count)
    {
        Quantity = count;
    }

    public int Quantity { get; private set; }

    public void DecreaseQuantity() => Quantity--;
}
