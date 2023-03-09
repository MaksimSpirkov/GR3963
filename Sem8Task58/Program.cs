// Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.

Console.Clear();

// Создаем две матрицы
Random rand = new Random();

int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix1[i, j] = rand.Next(10);
        matrix2[i, j] = rand.Next(10);
    }
}

// Выводим матрицы на экран
Console.WriteLine("Матрица 1:");
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        Console.Write(matrix1[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Матрица 2:");
for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        Console.Write(matrix2[i, j] + " ");
    }
    Console.WriteLine();
}

// Получаем количество строк и столбцов в каждой матрице
int rows1 = matrix1.GetLength(0);
int cols1 = matrix1.GetLength(1);
int rows2 = matrix2.GetLength(0);
int cols2 = matrix2.GetLength(1);

// Проверяем, можно ли умножить матрицы
if (cols1 != rows2)
{
    Console.WriteLine("Умножение матриц невозможно!");
    return;
}

// Создаем новую матрицу для хранения результата
int[,] resultMatrix = new int[rows1, cols2];

// Производим умножение матриц в циклах
for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        int sum = 0;

        for (int k = 0; k < cols1; k++)
        {
            sum += matrix1[i, k] * matrix2[k, j];
        }

        resultMatrix[i, j] = sum;
    }
}

// Выводим результирующую матрицу на экран
Console.WriteLine("Результирующая матрица:");

for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        Console.Write(resultMatrix[i, j] + "\t");
    }

    Console.WriteLine();
}