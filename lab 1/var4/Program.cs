using System;

namespace var2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть опір 1 резистора(Ом): ");
            float r1 = float.Parse(Console.ReadLine());
            
            Console.Write("Введіть опір 2 резистора(Ом): ");
            float r2 = float.Parse(Console.ReadLine());
            
            Console.Write("Введіть опір 3 резистора(Ом): ");
            float r3 = float.Parse(Console.ReadLine());

            float r = r1 + r2 + r3;
            Console.WriteLine($"Опір електричного ланцюга: {r} Ом");
        }
    }
}