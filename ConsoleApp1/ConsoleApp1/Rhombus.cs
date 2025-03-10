using System;

public class Rhombus : Square
{
    private double _d1;
    private double _d2;

    public Rhombus(string name, double a, double d1, double d2)
        : base(name, a)
    {
        D1 = d1;
        D2 = d2;
    }

    public double D1
    {
        get => _d1;
        set
        {
            if (value <= 0) throw new ArgumentException("D1 debe ser > 0");
            _d1 = value;
        }
    }

    public double D2
    {
        get => _d2;
        set
        {
            if (value <= 0) throw new ArgumentException("D2 debe ser > 0");
            _d2 = value;
        }
    }

    // Área = (D1 * D2) / 2
    public override double GetArea() => (D1 * D2) / 2;

    // Perímetro = 4 * A (usa el lado heredado de Square)
    public override double GetPerimeter() => 4 * A;
}