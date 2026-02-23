using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введіть периметр (p): ");
if (double.TryParse(Console.ReadLine(), out double p) && p > 0)
{
    double a = p / 3;
    double area = (Math.Sqrt(3) / 4) * Math.Pow(a, 2);

    Console.WriteLine($"Сторона: {a:F2}");
    Console.WriteLine($"Площа: {area:F4}");
}
else
{
    Console.WriteLine("Помилка введення!");
}
