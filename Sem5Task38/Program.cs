// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементом массива.

int i, n, sum = 0;
int[] m = new int[100];

Random rand = new Random();
n = 11;
Console.WriteLine("Сгенерированный массив: ");
for (i = 0; i < n; i++)
    {
        m[i] = rand.Next(0, 50);
        Console.Write(m[i] + " ");
    }
int min = m[0];
int max = m[0];

for (i = 0; i < n; i++)
{
    if (m[i] < min)
    {
        min = m[i];
    }
    else if (m[i] > max)
    {
        max = m[i];
    }
}
Console.WriteLine("\nМинимальный элемент: " + min);
Console.WriteLine("Максимальный элемент: " + max);
sum = max - min;
Console.WriteLine("Разницу между максимальным и минимальным элементом массива: " + sum);