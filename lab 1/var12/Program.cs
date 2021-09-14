using System;

namespace var12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть об'єм 1(л): ");
            float v1 = float.Parse(Console.ReadLine());
            
            Console.Write("Введіть температуру 1(°С): ");
            float t1 = float.Parse(Console.ReadLine());
            
            Console.Write("Введіть об'єм 2(л): ");
            float v2 = float.Parse(Console.ReadLine());
            
            Console.Write("Введіть температуру 2(°С): ");
            float t2 = float.Parse(Console.ReadLine());

            float v = v1 + v2;
            
            //Потрібно додати 273 градуси, щоб перевести у кельвіни
            //q - енергія води. q = cmt
            //v беремо замість m, тому що воно майже однакове
            float q1 = v1 * (t1 + 273);

            float q2 = v2 * (t2 + 273);

            //Їх загальна енергія
            float q = q1 + q2;

            //Віднімаємо 273, щоб перевести у цельсія
            float t = q / v - 273;
            Console.WriteLine($"Температура змішаної води: {t}°С");
        }
    }
}