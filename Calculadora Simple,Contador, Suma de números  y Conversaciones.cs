using System;

namespace Practica_1
{
    public static class Program
    {
        public static void Main()
        {


            Console.WriteLine("CALCULADORA SIMPLE ");

            double num1 = 0;
            double num2 = 0;
            double resultado = 0;


            Console.WriteLine("Opcion 1: Suma");
            Console.WriteLine("Opcion 2: Resta");
            Console.WriteLine("Opcion 3: Multiplicacion");
            Console.WriteLine("Opcion 4: Divicion");
            Console.WriteLine("Ingresa la Opcion: ");
            int opciones = int.Parse(Console.ReadLine());


            Console.Write("Ingresa el primer número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            num2 = double.Parse(Console.ReadLine());



            switch (opciones)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine("Resultado: " + resultado);


                    break;

                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 3:
                    resultado = num1 * num2;


                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;

                        Console.WriteLine("Resultado: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre cero.");
                    }
                    break;

                default:
                    Console.WriteLine("Operación no válida.");
                    break;
            }

            Console.WriteLine("CONTADOR DE POSITIVOS Y NEGATIVOS");
            int numero = 1;


            int positivos = 0;
            int negativos = 0;


            Console.WriteLine("Ingresa números (0 para terminar):");

            while (numero != 0)
            {
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    positivos++;
                }
                else if (numero < 0)
                {
                    negativos++;
                }
            }

            Console.WriteLine("Cantidad de positivos: " + positivos);
            Console.WriteLine("Cantidad de negativos: " + negativos);


            Console.WriteLine("SUMA DE LOS PRIMEROS N NÚMEROS");
            int N = 0;
            int suma = 0;
            int i = 1;


            Console.Write("Ingresa un número entero N: ");
            N = int.Parse(Console.ReadLine());

            do
            {
                suma = suma + i;
                i++;
            } while (i <= N);

            Console.WriteLine("La suma de 1 a " + N + " es: " + suma);

            Console.WriteLine("MENÚ DE CONVERSIONES ");
            int opcion;
            double dato;
            double resul;


            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. km/h a m/s");
            Console.WriteLine("3. Pesos a dólares");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingresa grados Celsius: ");
                    dato = double.Parse(Console.ReadLine());
                    resul = (dato * 9 / 5) + 32;
                    Console.WriteLine("Fahrenheit: " + resul);
                    break;

                case 2:
                    Console.Write("Ingresa km/h: ");
                    dato = double.Parse(Console.ReadLine());
                    resul = dato / 3.6;
                    Console.WriteLine("m/s: " + resul);
                    break;

                case 3:
                    Console.Write("Ingresa pesos: ");
                    dato = double.Parse(Console.ReadLine());
                    resul = dato / 17.0;
                    Console.WriteLine("Dólares: " + resul);
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }


        }
    }

}
