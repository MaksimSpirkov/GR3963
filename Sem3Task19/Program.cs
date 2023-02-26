// Программа, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите пятизначное число: ");
        string? number = Console.ReadLine();
        string rev = string.Concat(number.Reverse());
        Console.WriteLine(number == rev ? "Палиндром" : "Не палиндром");
    }
}