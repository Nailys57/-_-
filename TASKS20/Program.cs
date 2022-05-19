//производное двух массивов
using System;
using static System.Console;
Clear();

int[,] mass1 = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
    {5, 2, 6, 7},
};

int[,] mass2 = {
    {1, 5, 8, 5},
    {4, 9, 4, 2},
    {7, 2, 2, 6},
    {2, 3, 4, 7},
};

int[,] totalarray = new int[mass1.GetLength(0), mass1.GetLength(1)];//массив для производных

void FillArray(int[,] array)//заполнить массив производными
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = mass1[i, j] * mass2[i, j];
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

FillArray(totalarray);
PrintArray(totalarray);
