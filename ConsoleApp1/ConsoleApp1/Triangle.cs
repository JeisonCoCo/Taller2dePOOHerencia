using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Triangle : Rectangle
    {
        private double _c;
        private double _h;

        public Triangle(string name, double a, double b, double c, double h)
            : base(name, a, b)
        {
            C = c;
            H = h;
        }

        public double C
        {
            get => _c;
            set => _c = ValidateC(value);
        }

        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        protected double ValidateC(double value)
        {
            if (value <= 0)
                throw new ArgumentException("El lado C debe ser mayor que 0.");
            return value;
        }

        protected double ValidateH(double value)
        {
            if (value <= 0)
                throw new ArgumentException("La altura H debe ser mayor que 0.");
            return value;
        }

        // Área = (B * H) / 2  (B viene de Rectangle)
        public override double GetArea() => (B * H) / 2;

        // Perímetro = A + B + C
        public override double GetPerimeter() => A + B + C;
    }

}
