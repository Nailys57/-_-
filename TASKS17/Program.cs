using System;
using static System.Console;
Clear();

int[,] mass = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};

Write("введите номер элемента: ");
int position = int.Parse(ReadLine());
int array = mass.Length;

if (position <= array)
{
    int i = 0;
    int j = 0;
    for (int counter = 2; counter <= position; counter++)
    {
        if(j < mass.GetLength(1) - 1)
        {
           j++;
        }
        else
        {
            j = 0;
            i++;
        }   
    }
    WriteLine(mass[i, j]);
}
else WriteLine("Такрго элемента нет");