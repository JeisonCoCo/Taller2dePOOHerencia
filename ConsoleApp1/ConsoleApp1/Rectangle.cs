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
            set => _b = ValidateB(value);
        }

        protected double ValidateB(double value)
        {
            if (value <= 0)
                throw new ArgumentException("El lado B debe ser mayor que 0.");
            return value;
        }

        public override double GetArea() => A * B;
        public override double GetPerimeter() => 2 * (A + B);
    }
}