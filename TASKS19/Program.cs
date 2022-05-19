// упорядочить массив
using System;
using static System.Console;
Clear();

int[,] mass = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};

int[,] temparray = new int[mass.GetLength(0), mass.GetLength(1)];//временный двумерный массив
int[] temp = new int[mass.GetLength(1)];//массив для компиляции

void FillArray(int[,] array)//заполнить массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = mass[i, j];
        }
    }
};

void ComparisonArray(int[,] array, int[,] array1)//упорядочить массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp[j] = array[i, j];
        }
        Array.Sort(temp);

        for (int k = 0; k < array.GetLength(1); k++)
        {
            array1[i, k] = temp[k];
        }
    }
};

void PrintArray(int[,] array)//вывести массив в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
};

FillArray(temparray);
ComparisonArray(mass, temparray);
PrintArray(temparray);