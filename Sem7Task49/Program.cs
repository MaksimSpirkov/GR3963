﻿// Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти 
// элементы на их квадраты.

Console.Clear();
//метод читает данные от пользователя
int  ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
//метод генерации массива
int[,] Gen2DArr(int Row,int Coloumn,int min,int max)
{
    
    int[,] arr=new int[Row,Coloumn];
    for(int i=0;i<Row;i++)
    {
        for(int j=0;j<Coloumn;j++)
        {
            arr[i,j]=new Random().Next(min,max+1);
        }
    }
    return arr;
} 

void Print2DArr(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.DarkRed};
    for(int i=0; i<arr.GetLength(0);i++)
    {
        for(int j=0; j<arr.GetLength(1);j++)
        {
            Console.ForegroundColor=col[new Random().Next(0,3)];
            Console.Write(arr[i,j]+"\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    } 
}

void Update2DArr(int [,]arr)
{
   for(int i=1; i<arr.GetLength(0);i+=2)
    {
        for(int j=1; j<arr.GetLength(1);j+=2)
        {
           arr[i,j]*=arr[i,j];
        } 
        }
}
int row =ReadData("Количество строк");
int column=ReadData("Количество столбцов");
int[,] arr2D= Gen2DArr(row,column,10,99);
Update2DArr(arr2D);
Print2DArr(arr2D);