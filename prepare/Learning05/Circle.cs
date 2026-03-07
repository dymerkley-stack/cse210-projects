using System.Net.NetworkInformation;

public class Circle : Shape
{
    private double _radius;
    public Circle (string color, double rad) : base(color)
    {
        _radius = rad;
    }
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}