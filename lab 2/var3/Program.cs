using System;

namespace var3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть nn: ");
            int nn = int.Parse(Console.ReadLine());
            
            Console.Write("Введіть nk: ");
            int nk = int.Parse(Console.ReadLine());

            if (0 <= nn && nn <= nk)
            {
                float result = 0;
                for (int k = nn; k <= nk; k++)
                {
                    result += (MathF.Pow(k, 2) - MathF.Pow(-1, k + 1) * MathF.Pow(k, 3)) / (MathF.Pow(k, 2) + k + 1);
                }
                Console.WriteLine($"Результат: {result}");
            }
            else
            {
                Console.WriteLine("Невірні дані");
            }
        }
    }
}