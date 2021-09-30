using System;

namespace var7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть число 1: ");
            int n1 = int.Parse(Console.ReadLine());
            
            Console.Write("Введіть число 2: ");
            int n2 = int.Parse(Console.ReadLine());
            
            Console.Write("Введіть число 3: ");
            int n3 = int.Parse(Console.ReadLine());

            bool res = (n1 == n2) || (n1 == n3) || (n2 == n3);
            Console.WriteLine($"Є хоч би одна пара співпадаючих: {res}");
        }
    }
}