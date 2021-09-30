using System;

namespace var13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть число: ");
            int n = int.Parse(Console.ReadLine());

            bool res;
            
            //Якщо тризначне
            if (n / 100 >= 1 && n / 100 <= 9)
            {
                //Кількість сотень - тобто 1 цифра
                int n1 = n / 100;
                //Остача від ділення на сотню, тобто 2 і 3 цифри. Після ділимо на 10, щоб дізнатися кількість десятків - тобто 2 цифру
                int n2 = (n % 100) / 10;
                //Остача від ділення на десять, тобто остання цифра
                int n3 = n % 10;

                res = (n1 < n2) && (n2 < n3);
            }
            else
            {
                res = false;
            }
            
            Console.WriteLine($"Цифри утворюють зростаючу послідовність: {res}");
        }
    }
}