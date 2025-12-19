using System;

namespace EXÁMEN;

public static class Program
{
    public static void Main()
    {


        {
            int opcion;
            int num;
            int resul;

            do
            {
                Console.WriteLine("MENÚ DE OPERACIONES:");
                Console.WriteLine("1. Calcular el doble de un número");
                Console.WriteLine("2. Calcular el triple de un número");
                Console.WriteLine("3. Calcular el cuadrado de un número");
                Console.WriteLine("4. Salir");
                Console.WriteLine("");

                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingresa un número entero: ");
                        num = int.Parse(Console.ReadLine());
                        resul = num * 2;
                        Console.WriteLine("El resultado es: " + resul);
                        break;
                    case 2:
                        Console.Write("Ingresa un número entero: ");
                        num = int.Parse(Console.ReadLine());
                        resul = num * 3;
                        Console.WriteLine("El resultado es: " + resul);
                        break;

                    case 3:
                        Console.Write("Ingresa un número entero: ");
                        num = int.Parse(Console.ReadLine());
                        resul = num * num;
                        Console.WriteLine("El resultado es: " + resul);
                        break;

                    case 4:
                        Console.WriteLine("Gracias por util izar el program ¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine();
            } while (opcion != 4);
        }
    }
}

