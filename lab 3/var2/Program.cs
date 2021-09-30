using System;

namespace var2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть x: ");
            float x = float.Parse(Console.ReadLine());
            
            Console.Write("Введіть y: ");
            float y = float.Parse(Console.ReadLine());

            bool res = x < 0 && y > 0;
            Console.WriteLine($"Точка лежить в другому квадранті: {res}");
        }
    }
}