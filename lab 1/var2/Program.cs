using System;

namespace var2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть значення напруги(В): ");
            float u = float.Parse(Console.ReadLine());
            
            Console.Write("Введіть значення опору(Ом): ");
            float r = float.Parse(Console.ReadLine());

            float i = u / r;
            Console.WriteLine($"Струм: {i} А");
        }
    }
}