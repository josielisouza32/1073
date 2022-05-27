using System;

namespace _1073
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //definir variaveis
            int x, v;
            int[] N = new int[10];

            //ler valor V
            int.TryParse(Console.ReadLine(), out v);
            x = v;

             for (int i = 0; i < 10; i++)
            {
                N[i] = x;
                x = x * 2;
            }
            for (int i = 0; i < 10; i++)
            {
                {
                    Console.WriteLine($"N[{i}] = " + N[i]);

                }
            }
        }
    }
}