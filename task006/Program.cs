// Определить четность числа
using System;
using static System.Console;

Write("Введите число: ");
int a=int.Parse(ReadLine() );

if(a % 2==1)
Console.WriteLine($"Число {a} не четное");
else
Console.WriteLine($"Число {a} четное");