using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Kite : Rhombus
    {
        private double _b; // lado adicional

        public Kite(string name, double a, double b, double d1, double d2)
            : base(name, a, d1, d2)
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

        // Área = (D1 * D2) / 2 (igual que el rombo)
        public override double GetArea() => (D1 * D2) / 2;

        // Perímetro = 2 * (A + B)
        public override double GetPerimeter() => 2 * (A + B);
    }
}

