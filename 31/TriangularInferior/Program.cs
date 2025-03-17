using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangularInferior
{
    class Program
    {

        static void Main()
        {
            try
            {
                Console.Write("Ingrese el orden de la matriz: ");
                int n = int.Parse(Console.ReadLine());

                Matriz matriz = new Matriz(n);
                matriz.MostrarMatriz();
                matriz.MostrarTriangularInferior();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
