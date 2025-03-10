using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Kite : Rhombus
    {
        private double _b;

        public Kite(string name, double a, double b, double d1, double d2)
            : base(name, a, d1, d2)
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
        public override double GetArea() => (D1 * D2) / 2;
        public override double GetPerimeter() => 2 * (A + B);
    }
}
