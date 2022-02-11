using System;

namespace ej_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Ingrese la longitud");
            n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Ingrese un numero:", (i + 1));
                vector[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int aux;
                    if (vector[i] > vector[j])
                    {
                        aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }

                }
            }
            Console.WriteLine("Ordenado");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vector[i]);
            }
            Console.ReadKey();
        }
    }
}
