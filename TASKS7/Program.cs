//проверка на палиндром
using System;
using static System.Console;
Clear();

Write("Введите пятизначное чило: ");
string x=Console.ReadLine();

if (x.Reverse().SequenceEqual(x)) Console.WriteLine("Yes");
else
WriteLine("NO");
