//сумму элементов, стоящих на нечётных позициях
using System;
using static System.Console;
Clear();

int sum=0;
Write("Введите количество элементов массива: ");
int n = int.Parse(ReadLine());
Random rnd = new Random();
 int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(1, 100);
                if(i % 2 != 0)
                    sum += a[i];
            }           
            foreach (int s in a) Write(s+ " ");
            WriteLine();
            WriteLine(sum);