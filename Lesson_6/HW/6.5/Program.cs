﻿// Напишите программу, которая будет создавать копию заданного массива
// с помощью двумерного массива. Задание с семинара

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; i < row_size; j++)
        Console.Write($" {arr[i,j], 4}");
    Console.WriteLine();
    } 
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
        arr[i,j] = new Random().Next(from, to +1);
    
    return arr;
}

int[,] CopyMass(int [,] arr)
{
    int row_size = arr.GetLength (0);
    int column_size = arr.GetLength(1);
    int[,] new_arr = new int[row_size, column_size];

    for(int i = 0; i < row_size; i++)
        for (int j = 0; j < column_size; j++)
            new_arr[i,j] = arr[i,j];
    
    return new_arr;
}

Console.Write("Введите число в строку ");
int row_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число в столбец ");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Введите минимальное число массива ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное число массива ");
int stop = int.Parse(Console.ReadLine()!);
