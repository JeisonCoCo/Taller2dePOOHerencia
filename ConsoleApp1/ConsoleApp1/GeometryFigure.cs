using System;
using System.Collections.Generic;

namespace Geometry
{

    public abstract class GeometricFigure
    {
        public string Name { get; set; }

    public double D2
    {
        get => _d2;
        set => _d2 = ValidateD2(value);
    }

        protected GeometricFigure(string name) => Name = name;
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public override string ToString()
        {
            // Ajusta el número de decimales a tu gusto (F5 = 5 decimales)
            return $"{Name} => Area.....: {GetArea():F5}\tPerimeter: {GetPerimeter():F5}";
            {
                // Ajusta el número de decimales a tu gusto (F5 = 5 decimales)
                return $"{Name} => Area.....: {GetArea():F5}\tPerimeter: {GetPerimeter():F5}";
            }
        }
    }
}