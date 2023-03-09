// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] arr = new int[4, 4]; // создаем двумерный массив

Random rnd = new Random(); // создаем объект класса Random

// заполняем массив случайными числами
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rnd.Next(1, 10); // генерируем случайное число от 1 до 9
    }
}

// выводим массив на экран
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}

// проходим по столбцам
for (int j = 0; j < arr.GetLength(1); j++)
{
    int sum = 0; // сумма элементов в столбце
    int count = 0; // количество элементов в столбце

    // проходим по элементам в столбце
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j]; // добавляем элемент к сумме
        count++; // увеличиваем количество элементов
    }

    double average = (double)sum / count; // вычисляем среднее арифметическое

    Console.WriteLine($"Среднее арифметическое элементов в столбце {j}: {average}");
}