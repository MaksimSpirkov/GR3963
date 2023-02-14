//Программа, которая на вход принимает два числа и выдаёт, какое число
//большее, а какое меньшее.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.Write("Данное число больше: " + number1);
}
else
{
    Console.Write("Данное число больше: " + number2);
}