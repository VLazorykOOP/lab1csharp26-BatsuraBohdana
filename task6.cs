using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("x: ");
double x = double.Parse(Console.ReadLine() ?? "0");

Console.Write("y: ");
double y = double.Parse(Console.ReadLine() ?? "0");

if (x * y == 0)
{
    Console.WriteLine("Ділення на нуль!");
}
else
{
    double res = (1 / (x * y) + 1 / (Math.Pow(x, 2) + 1)) * (x + y);
    Console.WriteLine($"Результат: {res:F4}");
}
