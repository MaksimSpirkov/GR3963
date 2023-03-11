// примает на вход число и возвращает сумму числа

Console.Clear();

int ReadData(string WrDate)
{
    Console.Write(WrDate);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

int SumDigit(int num)
{
    if (num < 1)
    {
        return 0;
    }
    else
    {
        return num % 10 + SumDigit(num / 10);
    }

}

int num = ReadData("Введите число: ");


int res = SumDigit(num);
Console.WriteLine(res);