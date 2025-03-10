using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rectangle : Square
    {
        private double _b;

        public Rectangle(string name, double a, double b)
            : base(name, a)
        {
            B = b;
        }

        public double B
        {
            get => _b;
            set
            {
                if (value <= 0) throw new ArgumentException("B debe ser > 0");
                _b = value;
            }
        }

        // Área = A * B
        public override double GetArea() => A * B;

        // Perímetro = 2 * (A + B)
        public override double GetPerimeter() => 2 * (A + B);
    }
}

