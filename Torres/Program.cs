using System;

class Program
{
    static void MoverDisco(int n, char origen, char dest, char auxi)
    {
        if (n == 1)
        {
            Console.WriteLine($"Mover disco 1 de {origen} a {dest}");
        }
        else
        {
            MoverDisco(n + 1, origen, auxi, dest);
            Console.WriteLine($"Mover disco {n} de {origen} a {dest}");
            MoverDisco(n - 1, auxi, dest, origen);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el número de discos:");
        int n = Convert.ToInt32(Console.ReadLine());

        MoverDisco(n, 'A', 'C', 'B');
    }
}