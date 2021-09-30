using System;

namespace var6
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

            int minIndex = 0;
            int maxIndex = 0;
            //Починаємо з 1, бо індекси вже стоять на нулях
            for (int i = 1; i < size; i++)
            {
                if (arr[i] < arr[minIndex])
                {
                    minIndex = i;
                }

                if (arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
            }

            int temp = arr[minIndex];
            arr[minIndex] = arr[maxIndex];
            arr[maxIndex] = temp;
            
            Console.Write("Масив:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($" {arr[i]}");
            }
            Console.WriteLine();
        }
    }
}