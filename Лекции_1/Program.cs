using System;
 
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] mass = {
                {1, 4, 7, 2},
                {5, 9, 2, 3},
                {8, 4, 2, 4},
            };

            int[,] b = new int[3, 4]; //массив для сортировки по строкам
            b[i, j] = mass[i, j];
            

            int[] temp = new int[mass.GetLength(1)];
 
            Console.WriteLine("\nСортировка по строкам: ");
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                    temp[j] = b[i, j];
                Array.Sort(temp);
                for (int k = 0; k < mass.GetLength(1); k++)
                {
                    b[i, k] = temp[k];
                    Console.Write("{0}\t", b[i, k]);
                }
                Console.WriteLine();
            }
 
            
        }
    }
