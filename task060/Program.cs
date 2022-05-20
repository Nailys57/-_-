//трехмерный массив
using System;
using static System.Console;
Clear();

int[,,] mass = new int[2, 2, 2];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        for (int t = 0; t < mass.GetLength(2); t++)
        {
            mass[i, j, t] = new Random().Next(10, 99);
        }
    }
}

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        for (int t = 0; t < mass.GetLength(2); t++)
        {
            Write($"{mass[i, j, t]}({i},{j},{t}) ");
        }
        WriteLine();
    }
    WriteLine();
}