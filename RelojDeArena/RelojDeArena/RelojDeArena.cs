using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelojDeArena
{
    internal class RelojDeArena
    {
        private int[,] matriz;
        private int orden;


        public RelojDeArena(int n)
        {
            if (n % 2 == 0 || n <= 0)
                throw new ArgumentException("N debe ser un número impar y mayor que 0.");

            orden = n;
            matriz = new int[n, n];
            LlenarMatriz();
        }

        private void LlenarMatriz()
        {
            int contador = 1;
            for (int i = 0; i < orden; i++)
            {
                for (int j = 0; j < orden; j++)
                {
          
                    if (j >= i && j < orden - i || j <= i && j >= orden - 1 - i)
                    {
                        matriz[i, j] = contador++;
                    }
                    else
                    {
                        matriz[i, j] = 0; 
                    }
                }
            }
        }

        public void MostrarMatriz()
        {
            Console.WriteLine("Matriz con patrón de reloj de arena:\n");
            for (int i = 0; i < orden; i++)
            {
                for (int j = 0; j < orden; j++)
                {
                    if (matriz[i, j] == 0)
                        Console.Write("  \t");
                    else
                        Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
