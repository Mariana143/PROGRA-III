using System;

namespace ej1

{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            int[] edad = new int[4];
            string[] nombre = new string[4];
            for (int i = 0; i < edad.Length; i++)
            {
                Console.WriteLine("Ingrese un nombre:"+i);
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Ingrese una edad");
                edad[i] = Convert.ToInt32(Console.ReadLine());
            }
            string seudo;
            //METODO BURBUJA
            for (int i = 0; i < (edad.Length - 1); i++)
            {
                for (int j = 0; j < (edad.Length - 1); j++)
                {
                    if (edad[j] > edad[j + 1])
                    {
                        temp = edad[j];
                        seudo = nombre[j];
                        edad[j] = edad[j + 1];
                        nombre[j] = nombre[j + 1];
                        edad[j + 1] = temp;
                        nombre[j + 1] = seudo;

                    }
                }

            }
            
            Console.WriteLine("orden:");
            for (int p = 0; p < edad.Length; p++)
            {
                Console.WriteLine(nombre[p] +':'+edad[p]);


            }
            Console.ReadLine();
        }
    }
    }

