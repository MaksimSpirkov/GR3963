//Возведение числа в квадрат

string? inputNum = Console.ReadLine();

if (inputNum != null)
{
    int number = int.Parse(inputNum);
    int outNum = number * number;
    Console.Write(outNum);
}