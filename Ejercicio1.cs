/*using System;
using System.Collections.Generic;

class Ejercicio1
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la cantidad de cadenas que desea alojar en la pila: ");
        if (int.TryParse(Console.ReadLine(), out int cantidadCadenas) && cantidadCadenas > 0)
        {
            Stack<string> pilaCadenas = new Stack<string>();

            for (int i = 0; i < cantidadCadenas; i++)
            {
                Console.Write($"Ingrese la cadena {i + 1}: ");
                string cadena = Console.ReadLine();
                pilaCadenas.Push(cadena);
            }
            int totalConsonantes = SumarConsonantesEnPila(pilaCadenas);
            Console.WriteLine($"Total de consonantes en la pila: {totalConsonantes}");
        }
        else
        {
            Console.WriteLine("ingresar un número entero positivo para la cantidad de cadenas.");
        }
    }

    static int SumarConsonantesEnPila(Stack<string> pilaCadenas)
    {
        int totalConsonantes = 0;
        string consonantes = "bcdfghjklmnpqrstvwxyz";

        foreach (string cadena in pilaCadenas)
        {
            foreach (char c in cadena.ToLower())
            {
                if (consonantes.Contains(c))
                {
                    totalConsonantes++;
                }
            }
        }

        return totalConsonantes;
    }
}*/
