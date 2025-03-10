using System;

namespace ConsoleApp1
{
    // CLASE BASE ABSTRACTA
    public abstract class GeometricFigure
    {
        public string Name { get; set; }

        protected GeometricFigure(string name)
        {
            Name = name;
        }

        // Métodos abstractos que las clases derivadas deben implementar
        public abstract double GetArea();
        public abstract double GetPerimeter();

        // Representación en cadena que muestra área y perímetro
        public override string ToString()
        {
            return $"{Name} => Area.....: {GetArea():F5}\tPerimeter: {GetPerimeter():F5}";
        }
    }
}
