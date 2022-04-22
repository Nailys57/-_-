// Показать 3-е число
using System;
using static System.Console;

Write("Введите трехзначное число: ");
int num=int.Parse(Console.ReadLine());

if(num > 99)
WriteLine((num / 100) % 10);
else
WriteLine("третьей цифры нет");
