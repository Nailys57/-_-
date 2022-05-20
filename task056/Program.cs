//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
using System;
using static System.Console;
Clear();

int[,] mass = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
    {5, 2, 6, 7},
};

int i = 0, l = 0;
int sum = 0;
int[] tempmass = new int[mass.GetLength(0)];

int SumArray()
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        sum = sum + mass[i, j];
    }
    return sum;
}

for (i = 0; i < mass.GetLength(0); i++)
{
    sum = 0;
    tempmass[i] = SumArray();
}

for (i = 0; i < tempmass.GetLength(0); i++)
{
    int minn = tempmass.Min();
    l++;
    if (tempmass[i] == minn)
    {
        WriteLine($"{l} строка.");

    }
}