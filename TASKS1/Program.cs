// Найти большее число из 3
Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine() );

Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine() );

Console.Write("Введите число 3: ");
int c = Convert.ToInt32(Console.ReadLine() );

int max = 0;

if(a >= b && a >= c)
max = a;
else if(b >= a && b >= c)
max = b;
else
max = c;
Console.WriteLine($"{max} больше всех")