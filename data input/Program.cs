
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] vet = new int[N];

        string[] s = Console.ReadLine().Split(" ");
        
        for (int i = 0; i < N; i++)
        {
            if (int.Parse(s[i])<0)
            {
                vet[i] = int.Parse(s[i]);
                Console.WriteLine(vet[i]);
            }
        }
    }
}
