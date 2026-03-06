// LINK DEL VIDEO: https://youtu.be/sJdg4CCSia0?si=Y83DahEQzvAF4R7R

using System;
using System.Linq;

namespace CONTRASEÑASIMPLE;

public static class Program
{
    public static void Main()
    {

        {
            string contraseña; // Variable para guardar la contraseña que ingrese el usuario
            bool validar; // Variable booleana para saber si la contraseña es válida o no

            do // Ciclo que se repetirá mientras la contraseña NO sea válida
            {
                validar = true; // Se asume que la contraseña es válida (hasta comprobar lo contrario)

                Console.WriteLine("Ingrese una contraseña:"); // Pide que ingresae una contraseña
                contraseña = Console.ReadLine();  // Lee lo que el usuario escribe y lo guarda en la variable contraseña



                if (contraseña.Length < 6)  // Validar que tenga al menos 6 caracteres
                {
                    Console.WriteLine("Debe tener al menos 6 caracteres.");// Lo escribe en la pantalla
                    validar = false; // Si no cumple, se marca como inválida
                }




                string minuscula = contraseña.ToLower();   // Esto es para poder verificar vocales sin importar si son mayúsculas o minúsculas

                // Validar que contenga al menos una vocal
                if (!(minuscula.Contains("a") ||
                      minuscula.Contains("e") ||
                      minuscula.Contains("i") ||
                      minuscula.Contains("o") ||
                      minuscula.Contains("u")))
                {
                    Console.WriteLine("Debe contener al menos una vocal.");//Lo escribe en la pantalla
                    validar = false; // Si no tiene vocal, es inválida
                }


                // Validar que contenga al menos un número
                if (!(contraseña.Contains("0") ||
                      contraseña.Contains("1") ||
                      contraseña.Contains("2") ||
                      contraseña.Contains("3") ||
                      contraseña.Contains("4") ||
                      contraseña.Contains("5") ||
                      contraseña.Contains("6") ||
                      contraseña.Contains("7") ||
                      contraseña.Contains("8") ||
                      contraseña.Contains("9")))
                {
                    Console.WriteLine("Debe contener al menos un número.");
                    validar = false; // Si no tiene número, es inválida
                }

            } while (!validar);   // El ciclo se repite mientras validar sea FALSE
                                  // Cuando validar sea TRUE, el ciclo termina

            Console.WriteLine("Contraseña válida"); // Se muestra este mensaje cuando cumple todas las condiciones
        }
    }

}
