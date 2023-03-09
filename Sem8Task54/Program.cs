// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.

Console.Clear();

// Создаем двумерный массив
int[,] array = new int[4, 4];
Random rnd = new Random();
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array[i, j] = rnd.Next(0, 10);
    }
}

// Выводим исходный массив на экран
Console.WriteLine("Исходный массив:");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("\nОтсортированный массив:");
// Создаем временный массив для хранения отсортированных строк
int[] temp = new int[array.GetLength(1)];

// Сортировка строк в обратном порядке
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp[j] = array[i, j];
    }
    Array.Reverse(temp);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = temp[j];
    }
}

// Вывод отсортированного массива
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}