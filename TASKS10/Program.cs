//Возвести А в степень B
using System;
using static System.Console;
Clear();

Write("Введите число A: ");
int a=Int32.Parse(ReadLine());
Write("Введите число B: ");
int b=Int32.Parse(ReadLine());
int stepen=b;

    WriteLine(Math.Pow(a, stepen));
