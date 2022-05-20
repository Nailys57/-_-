//количество чётных чисел в массиве
using System;
using static System.Console;
Clear();

int x=0;
Write("Введите количество элементов массива: ");
int n = int.Parse(ReadLine());
Random rnd = new Random();
 int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(100, 999);
                if(a[i]%2==0)
                    x++;                
            }
            foreach (int s in a) Write(s+ " ");
            WriteLine();
            WriteLine("четных: {0}", x);
