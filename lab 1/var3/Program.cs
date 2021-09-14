using System;

namespace var2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть значення напруги(В): ");
            float u = float.Parse(Console.ReadLine());
            
            Console.Write("Введіть значення струму(А): ");
            float i = float.Parse(Console.ReadLine());

            float r = u / i;
            Console.WriteLine($"Опір: {r} Ом");
        }
    }
}