using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Parallelogram : Rectangle
    {
        private double _h;

        public Parallelogram(string name, double a, double b, double h)
            : base(name, a, b)
        {
            H = h;
        }

        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        protected double ValidateH(double value)
        {
            if (value <= 0)
                throw new ArgumentException("La altura H debe ser mayor que 0.");
            return value;
        }

        // Área = base (A) * altura (H)
        public override double GetArea() => A * H;

        // Perímetro = 2 * (A + B)
        public override double GetPerimeter() => 2 * (A + B);
    }
}
