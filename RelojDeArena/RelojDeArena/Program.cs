using System;

namespace RelojDeArena
{


    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Ingrese un número impar para el orden de la matriz: ");
                int n = int.Parse(Console.ReadLine());

                RelojDeArena reloj = new RelojDeArena(n);
                reloj.MostrarMatriz();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}