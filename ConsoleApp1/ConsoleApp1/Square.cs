using Geometry;
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
        set => _a = ValidateA(value);
    }

    protected double ValidateA(double value)
    {
        if (value <= 0)
            throw new ArgumentException("El lado A debe ser mayor que 0.");
        return value;
    }

    public override double GetArea() => A * A;
    public override double GetPerimeter() => 4 * A;
}
