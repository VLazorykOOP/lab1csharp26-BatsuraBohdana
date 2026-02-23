using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введіть x: ");
double x = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Введіть y: ");
double y = double.Parse(Console.ReadLine() ?? "0");

double distSq = x * x + y * y;

if (x > 0 && distSq < 81)
{
    Console.WriteLine("Так");
}
else if ((x == 0 && y >= -9 && y <= 9) || (x >= 0 && Math.Abs(distSq - 81) < 0.0001))
{
    Console.WriteLine("На межі");
}
else
{
    Console.WriteLine("Ні");
}
