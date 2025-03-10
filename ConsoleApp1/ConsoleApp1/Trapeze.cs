using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Trapeze : Triangle
    {
        private double _a; // un lado adicional (usaremos "A" como base 1)
        private double _d; // el otro lado (superior o inferior)

        public Trapeze(string name, double a, double b, double c, double d, double h)
            : base(name, b, c, h)
        {
            _a = a;
            _d = d;
        }

        // Área = (B + D) * H / 2
        public override double GetArea()
        {
            return (B + _d) * H / 2;
        }

        // Perímetro = A + B + C + D
        public override double GetPerimeter()
        {
            return _a + B + C + _d;
        }

        public override string ToString()
        {
            // Sobrescribimos ToString para respetar el formato del padre
            // pero usando nuestras fórmulas
            return $"{Name} => Area.....: {GetArea():F5}\tPerimeter: {GetPerimeter():F5}";
        }
    }
}
