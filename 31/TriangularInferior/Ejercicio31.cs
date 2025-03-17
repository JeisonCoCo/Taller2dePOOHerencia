using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangularInferior
{
    public class Matriz
    {
        private int[,] matriz;
        private int orden;

        public Matriz(int n)
        {
            if (n <= 0)
                throw new ArgumentException("El orden de la matriz debe ser mayor a 0.");

            orden = n;
            matriz = new int[n, n];
            LlenarMatriz();
        }

        private void LlenarMatriz()
        {
            for (int i = 0; i < orden; i++)
            {
                for (int j = 0; j < orden; j++)
                {
                    matriz[i, j] = i + j;
                }
            }
        }

        public void MostrarMatriz()
        {
            Console.WriteLine("Matriz completa:");
            for (int i = 0; i < orden; i++)
            {
                for (int j = 0; j < orden; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void MostrarTriangularInferior()
        {
            Console.WriteLine("\nTriangular Inferior:");
            for (int i = 0; i < orden; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
