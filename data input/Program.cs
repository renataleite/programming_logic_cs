
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        string[] vet = Console.ReadLine().Split(" ");
        int l = int.Parse(vet[0]);
        int c = int.Parse(vet[1]);
        
        int[,] mat;
        mat = new int[l,c];

        for (int i = 0; i < l; i++)
        {
            vet = Console.ReadLine().Split(" ");
            for (int j = 0; j < c; j++)
            {
                mat[i, j] = int.Parse(vet[j]);
            }
        }


        for (int i = 0; i < l; i++)
        {
            int sum = 0;
            for (int j = 0; j < c; j++)
            {
                sum += mat[i, j];
            }
            Console.WriteLine(sum + " ");
        }
    }
}
