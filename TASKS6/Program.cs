// Сегодня выходной?
using System;
using static System.Console;

Write("Какой сейчас день недели?: ");
int num=int.Parse(Console.ReadLine());

if(num<6)
WriteLine("нет");
else
WriteLine("да");