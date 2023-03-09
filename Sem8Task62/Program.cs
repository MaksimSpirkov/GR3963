// Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();

// задаем размер квадратной матрицы
int n = 4;
// создаем квадратную матрицу размером n на n
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

// заполняем ячейки матрицы значениями в спиральном порядке
while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  
  // заполняем матрицу в спиральном порядке
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

// метод для вывода матрицы на экран
WriteArray(sqareMatrix);

// перебираем все элементы матрицы и выводим их на экран
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
        Console.Write($" {array[i,j]} ");
      else 
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}