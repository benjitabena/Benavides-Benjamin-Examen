using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList numeros = new ArrayList();
        numeros.Add(5);
        numeros.Add(100);
        numeros.Add(32);
        numeros.Add(9);
        numeros.Add(15);

        int[] resultado = Adjacent(numeros);

        Console.WriteLine($"Mayor diferencia: {resultado[0]}");
        Console.WriteLine($"Índice del primer número: {resultado[1]}");
        Console.WriteLine($"Índice del segundo número: {resultado[2]}");
    }

    static int[] Adjacent(ArrayList numeros)
    {
        int mayorDiferencia = int.MinValue;
        int primerIndice = 0;
        int segundoIndice = 0;

        for (int i = 0; i < numeros.Count - 1; i++)
        {
            int diferencia = (int)numeros[i + 1] - (int)numeros[i];
            if (diferencia > mayorDiferencia)
            {
                mayorDiferencia = diferencia;
                primerIndice = i;
                segundoIndice = i + 1;
            }
        }

        int[] resultado = { mayorDiferencia, primerIndice, segundoIndice };
        return resultado;
    }
}
