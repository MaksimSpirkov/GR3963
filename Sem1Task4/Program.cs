//Программа, которая принимает на вход три числа и выдаёт максимальное из
//этих чисел.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

// не сработавшие попытки
//Console.log(Math.max(number1, number2, number3));
//Math.Max(number1, number2, number3);

int maximal = Math.Max(Math.Max(number1, number2), number3);

Console.Write("Максимальное число: " + maximal);