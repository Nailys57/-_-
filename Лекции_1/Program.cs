        int[,] mass = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        Console.WriteLine("Введите искомое число");
        int number = int.Parse(Console.ReadLine());



        var index = (
            from i in Enumerable.Range(0, mass.GetLength(0))
            from j in Enumerable.Range(0, mass.GetLength(1))
            where mass[i, j] == number
            select  (i, j)
            ).FirstOrDefault();



        Console.WriteLine($"Индексы {index.i} {index.j}");

        Console.ReadLine();