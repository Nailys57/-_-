using System;
using static System.Console;
Clear();

Write("Введите число: ");
int x=Int32.Parse(ReadLine());
int stepen=3;

for (int i = 1; i <= x; i++)
{
    WriteLine(Math.Pow(i, stepen));
}  