
using System;
using System.Diagnostics.Tracing;
using System.Threading;

class URI
{
    static void Main(string[] args)
    {
        int M = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());

        double[,] A;

        A = new double[M, N];

        for (int i = 0; i < M; i++)
        {
            string[] vet = Console.ReadLine().Split(" ");
            for (int j = 0; j < N; j++)
            {
                A[i, j] = double.Parse(vet[j]);
            }
        }

        int linhaEscolhida = int.Parse(Console.ReadLine()) - 1;

        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (linhaEscolhida == i)
                {
                    if (j == 0)
                    {
                        Console.Write(A[linhaEscolhida, N - 1] + " ");
                    }
                    else
                    {
                        Console.Write(A[linhaEscolhida, j - 1] + " ");
                    }
                }
                else
                {
                    Console.Write(A[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}


