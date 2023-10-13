namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;
public class Asteroid : IObstacle
{
    public Asteroid()
    {
    }

    public int Damage { get; }

    public int Quantity { get; private set; }

    public void DecreaseQuantity() => Quantity--;
}
