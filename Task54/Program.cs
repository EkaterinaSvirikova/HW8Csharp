// ** Задача 54.** Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Исходный массив:
// 1 4 7 2 
// 5 9 2 3
// 8 4 2 4
// Результат:
// 7 4 2 1
// 9 5 3 2 
// 8 4 4 2

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
Ordering(ar);
PrintArray(ar);
WriteLine();

void Ordering(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - i - 1; k++)
            {
                if (array[j, k] < array[j, k + 1])
                {
                    int t = array[j, k];
                    array[j, k] = array[j, k + 1];
                    array[j, k + 1] = t;
                }
            }
        }
    }
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

