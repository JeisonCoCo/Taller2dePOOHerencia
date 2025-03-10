using System;
using System.Collections.Generic;

namespace Geometry
{
    // CLASE BASE ABSTRACTA
    public abstract class GeometricFigure
    {
        public string Name { get; set; }

        protected GeometricFigure(string name)
        {
            Name = name;
        }

        // Métodos abstractos que cada figura concreta implementará
        public abstract double GetArea();
        public abstract double GetPerimeter();

        // Formato de impresión para que coincida con el resultado esperado
        public override string ToString()
        {
            // Ajusta las cifras decimales según lo requieras. Aquí se usan 5 decimales.
            return $"{Name} => Area.....: {GetArea():F5}\tPerimeter: {GetPerimeter():F5}";
        }
    }
