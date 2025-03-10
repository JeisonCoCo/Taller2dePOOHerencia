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
        set => _d1 = ValidateD1(value);
    }

    protected double ValidateD1(double value)
    {
        if (value <= 0)
            throw new ArgumentException("La diagonal D1 debe ser mayor que 0.");
        return value;
    }

    protected double ValidateD2(double value)
    {
        if (value <= 0)
            throw new ArgumentException("La diagonal D2 debe ser mayor que 0.");
        return value;
    }

    // Área = (D1 * D2) / 2
    public override double GetArea() => (D1 * D2) / 2;

    // Perímetro = 4 * A
    public override double GetPerimeter() => 4 * A;
}
