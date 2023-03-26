// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = SumOfNumbers(m, n); // вызов метода SumOfNumbers и сохранение результата в переменной sum
        Console.WriteLine($"Сумма чисел от {m} до {n} равна {sum}"); // вывод результата
    }

    // метод для вычисления суммы натуральных чисел в промежутке от m до n включительно
    static int SumOfNumbers(int m, int n)
    {
        if (m == n)
        {
            return m;
        }
        else
        {
            return m + SumOfNumbers(m + 1, n); // сумма равна m плюс сумме чисел от m+1 до n
        }
    }
}