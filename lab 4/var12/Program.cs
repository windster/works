using System;

namespace var12
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

            bool even = arr[0] % 2 == 0;
            bool minus = arr[0] < 0;
            bool success = true;
            for (int i = 1; i < size; i++)
            {
                bool newEven = arr[i] % 2 == 0;
                if (even == newEven)
                {
                    Console.WriteLine($"Було порушено чередування парних і непарних на елементі {i + 1}");
                    success = false;
                    break;
                }
                else
                {
                    even = newEven;
                }

                bool newMinus = arr[i] < 0;
                if (newMinus == minus)
                {
                    Console.WriteLine($"Було порушено чередування від'ємних і додатних на елементі {i + 1}");
                    success = false;
                    break;
                }
                else
                {
                    minus = newMinus;
                }
            }

            if (success)
            {
                Console.WriteLine("Чередування правильне");
            }
        }
    }
}