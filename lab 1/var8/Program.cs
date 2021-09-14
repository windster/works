using System;

namespace var8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть радіус кулі(см): ");
            float r = float.Parse(Console.ReadLine());

            //MathF замість Math, щоб рахувати в float, а не double
            float v = 4 * MathF.PI * MathF.Pow(r, 3) / 3;
            Console.WriteLine($"Об'єм кулі: {v} см3");

            float s = 4 * MathF.PI * MathF.Pow(r, 2);
            Console.WriteLine($"Площа кулі: {s} см2");
        }
    }
}