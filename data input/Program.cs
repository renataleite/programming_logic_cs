
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[,] mat;
        mat = new int[N,N];

        for (int i = 0; i < N; i++)
        {
            string[] vet = Console.ReadLine().Split(" ");
            for (int j = 0; j < N; j++)
            {
                mat[i, j] = int.Parse(vet[j]);
            }
        }

        Console.WriteLine("Diagonal Principal:");

        for (int i= 0; i <N; i++)
        {
            Console.Write(mat[i, i] + " ");
        }
        Console.WriteLine();
        int count = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if(mat[i,j] < 0)
                {
                    count++;
                }
            }
        }
        Console.WriteLine("Quantidade de Negativos = " + count);
    }
}
