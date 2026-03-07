using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Black", 5));
        shapes.Add(new Rectangle("Grey", 5, 2));
        shapes.Add(new Circle("Rainbow", 5));

        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }
        
        
    }
}