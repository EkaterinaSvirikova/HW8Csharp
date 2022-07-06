// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Исходный массив:
// 1 4 7 2 
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Результат:
// 1-строка

using System;
using static System.Console;
using System.Linq;
Clear();

Write("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine(). Split(' ',StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizeS[0]);
int columns = int.Parse(sizeS[1]);
int[,] ar = GetrandomArray(rows, columns);
PrintArray(ar);
WriteLine();
WriteLine($"Результат: {Sum(ar)} строка");
WriteLine();

int Sum(int[,] array)
{
    int sum = 0;
    int minSum = 0;
    int minNum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0) 
            {
                sum += array[i, j];
                minSum += array[i, j]; 
            }
            else sum += array[i, j]; 
        }
        if(sum < minSum)
        {
            minSum = sum;
            minNum = i;
        }
        sum = 0;
    }
    return minNum;
}

int[,] GetrandomArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for(int i = 0; i < result.GetLength(0); i++) 
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++) 
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

