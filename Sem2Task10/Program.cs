// Программа, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

System.Random numSintezator = new System.Random();

int num = new Random().Next(100, 1000);
Console.WriteLine(num);

int middleNumber = num / 10 % 10;

Console.WriteLine(middleNumber);