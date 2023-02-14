//Программа, которая на вход принимает число и выдаёт, является ли число чётным

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.Write("Число является четным");
}
else
{
    Console.Write("Число не четное");
}