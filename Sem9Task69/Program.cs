// Напишите программу, которая будет принимать 2 числа А и В,
// возыедите А в степень В с помощью рекурсии

int ReadDataToInt(string msg) 
{ 
    Console.Write(msg); 
    return (int.Parse(Console.ReadLine() ?? "0")); 
}
long RecPow(int a, int b) 
{
    if (b <= 1) { return a; } else { return a * (RecPow(a, b - 1)); } 
}
int a = ReadDataToInt("Введите число: "); 
int b = ReadDataToInt("Введите степень числа: "); 

Console.WriteLine("Ответ: " + RecPow(a, b));