//спирально заполнить массив
using System;
using static System.Console;
Clear();

int[,] mass = new int[4, 4];
int i = 0, j = 0, l = 1, n = 3;

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

for ( j = 0; j < mass.GetLength(1); j++)
{
    mass[i, j] = l;
    l++;
}
for (i = 0; i < mass.GetLength(0); i++)
{
    mass[i, n] = l;
    l++;
}
for (i = n -1; i >= 0; i--)
{
    mass[n, i] = l;
    l++;
}
for (i = n; i >= 1; i--)
{
    mass[i, n - 3] = l;
    l++;
}
for (j = 0; j <= n - 1; j++)
{
    mass[n - 2, j] = l;
    l++;
}
for (i = n - 2; i <= n - 1; i++)
{
    mass[i, n - 1] = l;
    l++;
}
for (j = n - 2; j >= n - 2; j--)
{
    mass[n - 1, j] = l;
    l++;
}

PrintArray(mass);