//Программа, которая на вход принимает число (N), а на выходе показывает
//все чётные числа от 1 до N.

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
        startNumber = startNumber + 2;
    }

    Console.Write(outLine);
}