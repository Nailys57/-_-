//массив размером m×n, заполненный случайными вещественными числами
using System;
using static System.Console;
Clear();

double[,] mass = new double[3, 4];

{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            var rand = new Random().Next(-10, 9);
            var randF = new Random().NextDouble();
            mass[i, j] = rand + randF;
        }     
    }
}

void PrintArray(double[,] array)//вывести массив в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write("{0:F1} ", array[i, j]);
        }
        WriteLine();
    }
};

PrintArray(mass);
