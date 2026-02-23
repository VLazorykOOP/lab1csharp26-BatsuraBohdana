using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введіть номер місяця (1-12): ");
int month = int.Parse(Console.ReadLine() ?? "1");

int daysInMonth = DateTime.DaysInMonth(2026, month);

Console.Write($"Введіть день (1-{daysInMonth}): ");
int currentDay = int.Parse(Console.ReadLine() ?? "1");

int remaining = daysInMonth - currentDay;

if (remaining >= 0 && currentDay > 0 && currentDay <= daysInMonth)
{
    Console.WriteLine($"Залишилося днів: {remaining}");
}
else
{
    Console.WriteLine("Некоректний день.");
}
