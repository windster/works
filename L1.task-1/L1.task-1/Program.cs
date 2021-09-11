using System;


namespace L1.task_1
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть довжину маятника в метрах: ");
            double l = double.Parse(Console.ReadLine());
            double t = 2 * Math.PI * Math.Sqrt(l / 9.81);
            Console.WriteLine("Період коливання равен {0}", t);
        }
    }
}
