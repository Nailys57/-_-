using System;
using static System.Console;
Clear();

Write("Введите х1=");
int ax = Int32.Parse(Console.ReadLine());
double x1 = Convert.ToDouble(ax);

Write("Введите х2=");
int ay = Int32.Parse(Console.ReadLine());
double x2 = Convert.ToDouble(ay);

Write("Введите х3=");
int az = Int32.Parse(Console.ReadLine());
double x3 = Convert.ToDouble(az);
 
Write("Введите у1=");
int bx = Int32.Parse(Console.ReadLine());
double y1 = Convert.ToDouble(bx);
 
Write("Введите у2=");
int by = Int32.Parse(Console.ReadLine());
double y2 = Convert.ToDouble(by);

Write("Введите y3=");
int bz = Int32.Parse(Console.ReadLine());
double y3 = Convert.ToDouble(bz);
 
 
double num = Math.Sqrt(Math.Pow((x1 - y1), 2) + Math.Pow((x2 - y2), 2) + Math.Pow((x3 - y3), 2));
num=Math.Round(num,2);
 
WriteLine("Результат равен = {0}", num);
