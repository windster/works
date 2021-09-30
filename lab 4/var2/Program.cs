using System;

namespace var2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість елементів: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введіть елемент {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            Console.Write("Елементи з парними індексами:");
            for (int i = 0; i < size; i += 2)
            {
                Console.Write($" {arr[i]}");
            }
            Console.WriteLine();
            
            Console.Write("Елементи з непарними індексами:");
            for (int i = 1; i < size; i += 2)
            {
                Console.Write($" {arr[i]}");
            }
            Console.WriteLine();
        }
    }
}