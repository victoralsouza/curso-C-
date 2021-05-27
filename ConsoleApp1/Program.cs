using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] vet = Console.ReadLine().Split(" ");
            double A = double.Parse(vet[0]);
            double B = double.Parse(vet[1]);
            double C = double.Parse(vet[2]);
            double D = double.Parse(vet[3]);
            double dif = A * B - C * D;

            Console.WriteLine($"A= " + A + "  B= " + B + "  C= " + C + " D= " + D);
            Console.WriteLine($"Diferenca = " + dif.ToString("F2"));
        }
    }
}
