using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Parallelogram : Rectangle
    {
        private double _h; // altura

        public Parallelogram(string name, double a, double b, double h)
            : base(name, a, b)
        {
            H = h;
        }

        public double H
        {
            get => _h;
            set
            {
                if (value <= 0) throw new ArgumentException("Altura debe ser > 0");
                _h = value;
            }
        }

        // Área = base * altura (tomamos la base como B, o A, según convenga; 
        // aquí asumimos A es la base, y B es el otro lado)
        // El diagrama sugiere: Área = B * H. Ajusta si tu interpretación es distinta.
        public override double GetArea() => B * H;

        // Perímetro = 2 * (A + B)
        public override double GetPerimeter() => 2 * (A + B);
    }
}
