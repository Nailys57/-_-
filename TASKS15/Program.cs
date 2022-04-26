//разницу между максимальным и минимальным элементов массива
using System;
using static System.Console;
Clear();

int max;
int min;
int dif;
Write("Введите количество элементов массива: ");
int n = int.Parse(ReadLine());
Random rnd = new Random();
 int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(1, 100);
            }
            min=a[0];
            max=a[0];
            for (int i = 0; i < n; i++)
            {
                if (min>a[i])
                    min=a[i];
                if (max<a[i])
                    max=a[i];
            }
            dif=max-min;
            foreach (int s in a) Write(s+ " ");
            WriteLine();
            WriteLine(min);
            WriteLine(max);
            WriteLine("Разница между min и max чилом в массиве: {0}", dif);