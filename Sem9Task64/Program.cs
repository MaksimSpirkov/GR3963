// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N. Выполнить 
// с помощью рекурсии.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        PrintNumbers(1, n); // вызов метода PrintNumbers
    }

    static void PrintNumbers(int start, int end) // метод для печати чисел от start до end включительно
    {
        if (start <= end)
        {
            Console.Write(start + " ");
            PrintNumbers(start + 1, end); // рекурсивно вызываем метод PrintNumbers
        }
    }
}