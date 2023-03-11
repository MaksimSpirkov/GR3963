// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = Ackermann(m, n); // вызов функции Аккермана с передачей аргументов m и n

        Console.WriteLine($"Значение функции Аккермана для чисел {m} и {n} равно {result}");
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0) // если m равно 0, возвращаем n+1
        {
            return n + 1;
        }
        else if (n == 0) // если n равно 0, вызываем функцию Аккермана с аргументами m-1 и 1
        {
            return Ackermann(m - 1, 1);
        }
        else // если оба числа больше 0, вызываем функцию Аккермана с аргументами m-1 и Ackermann(m, n-1)
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}