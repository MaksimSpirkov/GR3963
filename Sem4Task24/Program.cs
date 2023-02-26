//Программа, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();
if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    int startNumber = 2;
    string outLine = string.Empty;

    while (startNumber < inputNumber)
    {
        outLine = outLine + startNumber + ", ";
        startNumber = startNumber + 1;
    }

    Console.Write(outLine);
}