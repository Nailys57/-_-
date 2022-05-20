// Сравнение двух чисел
Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine() );

Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine() );

if(a > b)
Console.WriteLine($"{a} > {b}");
else if(a < b)
Console.WriteLine($"{a} < {b}");
else
Console.WriteLine($"{a} = {b}");