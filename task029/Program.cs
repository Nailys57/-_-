//Массив
using System;
using static System.Console;
Clear();

Write("Введите количество элементов массива: ");
int n = int.Parse(ReadLine());
Random rnd = new Random();
 int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(1, 100);
                
            }
            foreach (int s in a) Write(s+ " ");
            WriteLine();
