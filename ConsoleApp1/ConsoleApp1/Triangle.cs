using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Triangle : Rectangle
    {
        private double _c; // tercer lado
        private double _h; // altura para el cálculo de área (si la base es B)

        public Triangle(string name, double b, double c, double h)
            : base(name, 0, b) // "A" lo dejamos en 0, y B = b
        {
            C = c;
            H = h;
        }

        public double C
        {
            get => _c;
            set
            {
                if (value <= 0) throw new ArgumentException("C debe ser > 0");
                _c = value;
            }
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

        // Área = (B * H) / 2  (B es el segundo lado del padre)
        public override double GetArea() => (B * H) / 2;

        // Perímetro = A + B + C, pero A es 0 en este uso forzado. 
        // Para coincidir con la salida, se asume A=0 + B + C = B + C => 
        // sin embargo, en tu ejemplo final se ve que sí hay un valor 
        // que termina sumando. Ajusta según tu necesidad.
        // Aquí lo haremos "0 + B + C" = B + C, pero 
        // si el enunciado dice "Perimeter = A + B + C", añade un "A" si procede.
        public override double GetPerimeter() => A + B + C;
    }

}
