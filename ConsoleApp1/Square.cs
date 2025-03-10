using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Square : GeometricFigure
    {
        private double _a;

        public Square(string name, double a) : base(name)
        {
            A = a;
        }

        public double A
        {
            get => _a;
            set
            {
                if (value <= 0) throw new ArgumentException("Lado debe ser > 0");
                _a = value;
            }

        
        }
        private int ValidateA(double square)
        {
            if (square < 0 || square > 59)
            {
                throw new ArgumentException($"The second:{second}, not is valid.");
            }
            return second;
        }
        public override double GetArea() => A * A;
        public override double GetPerimeter() => 4 * A;
    }
}