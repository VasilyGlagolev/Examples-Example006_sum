using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("Число чётное");
        }
        else
        {
            Console.WriteLine("Число нечётное");
        }

        Console.ReadKey();
    }
}
 