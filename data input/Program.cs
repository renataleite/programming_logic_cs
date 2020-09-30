
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        int N;
        double sum;
        double[] A;
        string[] vet;

        N = int.Parse(Console.ReadLine());
        A = new double[N];

        vet = Console.ReadLine().Split(" ");
        sum = 0.0;

        for (int i = 0; i < N; i++)
        {
            A[i] = double.Parse(vet[i]);
        }
        for (int i = 0; i < N; i++)
        {
            Console.Write(A[i].ToString("F1") + " ");
            sum += A[i];
        }
        Console.WriteLine();
        Console.WriteLine(sum.ToString("F2"));
        Console.WriteLine((sum / N).ToString("F2"));
    }
}
