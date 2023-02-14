// Является ли первое число квадратом второго?

Console.Write("Введите первое число: ");
string? numLine1 = Console.ReadLine();
Console.Write("Введите второе число: ");
string? numLine2 = Console.ReadLine();
if (numLine1 != null && numLine2 != null)
{
    int num1 = int.Parse(numLine1);
    int num2 = int.Parse(numLine2);
    if (num2 * num2 == num1)
    {
        Console.Write("Является");
    }
    else
    {
        Console.Write("Не является");
    }

}