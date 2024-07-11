using System;

abstract class Shape
{
    public abstract void CalculatePerimeter();
    public abstract void CalculateArea();

    public override string ToString()
    {
        return "This is a shape";
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override void CalculateArea()
    {
        Console.WriteLine($"Area = {Width * Height}");
    }

    public override void CalculatePerimeter()
    {
        Console.WriteLine($"Perimeter = {2 * (Width + Height)}");
    }

    public override string ToString()
    {
        return $"Width: {Width}, Height: {Height}";
    }
}

class Square : Rectangle
{
    public double SideLength { get; set; }

    public override void CalculateArea()
    {
        Console.WriteLine($"Area = {SideLength * SideLength}");
    }

    public override void CalculatePerimeter()
    {
        Console.WriteLine($"Perimeter = {4 * SideLength}");
    }

    public override string ToString()
    {
        return $"Side Length: {SideLength}";
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public override void CalculatePerimeter()
    {
        Console.WriteLine($"Perimeter = {2 * Math.PI * Radius}");
    }

    public override void CalculateArea()
    {
        Console.WriteLine($"Area = {Math.PI * Radius * Radius}");
    }

    public override string ToString()
    {
        return $"Radius: {Radius}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Shape[] shapes = {
            new Rectangle { Width = 5, Height = 3 },
            new Square { SideLength = 4 },
            new Circle { Radius = 2.5 }
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine(shape);
            shape.CalculateArea();
            shape.CalculatePerimeter();
            Console.WriteLine();
        }
    }
}
