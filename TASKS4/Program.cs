// Показать 2-е число из 3-х
using System;
using static System.Console;

Write("Введите число: ");
int num=int.Parse(Console.ReadLine());

WriteLine((num%100)/10);