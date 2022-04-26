//Массив
using System;
using static System.Console;
Clear();

Write("Введите количество элементов массива: ");
int n = int.Parse(ReadLine());
 int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(ReadLine());
                
            }
            foreach (int s in a) Write(s+ " ");
            WriteLine();
