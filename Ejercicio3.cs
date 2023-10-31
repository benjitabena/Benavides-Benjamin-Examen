/*using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la cantidad de enteros que desea alojar en la cola: ");
        if (int.TryParse(Console.ReadLine(), out int cantidadEnteros) && cantidadEnteros > 0)
        {
            Queue<int> colaEnteros = new Queue<int>();

            for (int i = 0; i < cantidadEnteros; i++)
            {
                Console.Write($"Ingrese el entero {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int entero))
                {
                    colaEnteros.Enqueue(entero);
                }
                else
                {
                    Console.WriteLine("Error: Ingrese un número entero válido.");
                    i--; // Restar i para volver a pedir el mismo número.
                }
            }

            int minimo = EncontrarMinimoEnCola(colaEnteros);
            int maximo = EncontrarMaximoEnCola(colaEnteros);

            Console.WriteLine($"Valor mínimo en la cola: {minimo}");
            Console.WriteLine($"Valor máximo en la cola: {maximo}");
        }
        else
        {
            Console.WriteLine("Error: Debe ingresar un número entero positivo para la cantidad de enteros.");
        }
    }

    static int EncontrarMinimoEnCola(Queue<int> colaEnteros)
    {
        int minimo = int.MaxValue;
        foreach (int entero in colaEnteros)
        {
            if (entero < minimo)
            {
                minimo = entero;
            }
        }
        return minimo;
    }

    static int EncontrarMaximoEnCola(Queue<int> colaEnteros)
    {
        int maximo = int.MinValue;
        foreach (int entero in colaEnteros)
        {
            if (entero > maximo)
            {
                maximo = entero;
            }
        }
        return maximo;
    }
}
*/