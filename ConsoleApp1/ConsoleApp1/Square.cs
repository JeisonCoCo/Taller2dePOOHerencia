using System;

public class Square : GeometricFigure
{
    private double _a;

    public Square(string name, double a) : base(name)
    {
        A = a;
    }

    public double A
    {
        get => _a;
        set
        {
            if (value <= 0) throw new ArgumentException("Lado debe ser > 0");
            _a = value;
        }
    }

    public override double GetArea() => A * A;
    public override double GetPerimeter() => 4 * A;
}