using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("green", 3);
        Rectangle rectangle = new Rectangle("pink", 2, 4);
        Circle circle = new Circle("yellow", 2);

        List<Shape> shapes = new List<Shape>
        {
            square,
            rectangle,
            circle
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()} {shape.GetArea()}");
        }
    }
}