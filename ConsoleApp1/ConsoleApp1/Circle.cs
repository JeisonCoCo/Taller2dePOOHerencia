using Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Circle : GeometricFigure
    {
        private double _r;

        public Circle(string name, double r) : base(name)
        {
            R = r;
        }

        public double R
        {
            get => _r;
            set => _r = ValidateR(value);
        }

        private double ValidateR(double value)
        {
            if (value <= 0)
                throw new ArgumentException("El radio debe ser mayor que 0.");
            return value;
        }

        public override double GetArea() => Math.PI * R * R;
        public override double GetPerimeter() => 2 * Math.PI * R;
    }

}