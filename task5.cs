using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Перше число: ");
int n1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Друге число: ");
int n2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Різниця: {Subtract(n1, n2)}");

static int Subtract(int x, int y)
{
    return x - y;
}
