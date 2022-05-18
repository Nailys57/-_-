using System;
using static System.Console;
Clear();

int[,] mass = new int[3, 4];

{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            var rand = new Random().Next(-10, 9);
            var randF = new Random();
            Write("{0:F1} ", rand + randF.NextDouble());
        }
        WriteLine();
    }
}
