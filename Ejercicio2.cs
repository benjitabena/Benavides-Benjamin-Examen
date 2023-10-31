/*using System;
using System.Collections.Generic; 

class Ejercicio2
{
    static void Main(string[] args)
    {
        int[,] matriz1 = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int[,] matriz2 = {
            {9, 8, 7},
            {6, 5, 4},
            {3, 2, 1}
        };

        int[,] resultado = SumarMatrices(matriz1, matriz2);

        Console.WriteLine("Matriz 1:");
        ImprimirMatriz(matriz1);

        Console.WriteLine("\nMatriz 2:");
        ImprimirMatriz(matriz2);

        Console.WriteLine("\nResultado de la suma:");
        ImprimirMatriz(resultado);
    }

    static int[,] SumarMatrices(int[,] matriz1, int[,] matriz2)
    {
        int filas = matriz1.GetLength(0);
        int columnas = matriz1.GetLength(1);

        int[,] resultado = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        return resultado;
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
*/