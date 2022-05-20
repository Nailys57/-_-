// Показать все четные числа в диапазоне
using System;
using static System.Console;

Write("Введите число: ");
int a=int.Parse(ReadLine());
int x=1;

for (int i=x; i<=a; i++)
if(i%2==0)
WriteLine($"{i}");