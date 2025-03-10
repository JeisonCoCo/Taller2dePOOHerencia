using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Circle : Geometry.GeometricFigure
    {
        private double _r;

        public Circle(string name, double r) : base(name)
        {
            R = r;
        }

        public double R
        {
            get => _r;
            set
            {
                if (value <= 0) throw new ArgumentException("Radio debe ser > 0");
                _r = value;
            }
        }

        public override double GetArea() => Math.PI * R * R;
        public override double GetPerimeter() => 2 * Math.PI * R;
    }
}