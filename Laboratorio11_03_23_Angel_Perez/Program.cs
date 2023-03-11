using System;

namespace Laboratorio11_03_23_Angel_Perez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a. Sumatoria");
            Console.WriteLine("b. Tablas de multiplicar");
            char opcion = Convert.ToChar(Console.ReadLine());

            switch (opcion)
            {
                case 'a':

                    Console.WriteLine("Ingrese un numero:");
                    int n = Convert.ToInt32(Console.ReadLine());

                    int resultado = 0;


                    do
                    {
                        resultado = resultado + n;
                        n--;
                    } while (n > 0);

                    Console.WriteLine("Sumatoria" + resultado);
                    break;

                case 'b':
                    for (int i = 1; i < 11; i++)
                    {
                        Console.Write(i + ": ");
                        for (int j = i; j < 11; j++)
                        {
                            Console.Write((i * j) + "\t");
                        }
                        Console.Write("\n");
                    }
                    break;
            }
            

           
        }
    }
}
