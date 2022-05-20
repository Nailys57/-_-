//среднее арифметическое элементов в каждом столбце
using System;
using static System.Console;
Clear();

int[,] mass = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};

int j = 0;
double SumArray()
{
    double sum = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        sum = sum + mass[i, j];
    }
    return sum;
}

for (int x = 0; x < mass.GetLength(1); x++)
{
    double average = SumArray() / mass.GetLength(0);
    average = Math.Truncate(10 * average) / 10;
    Write($"{average}, ");
    j++;
}
WriteLine();
