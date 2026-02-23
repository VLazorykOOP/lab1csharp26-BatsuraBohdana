using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введіть ціле число: ");
if (int.TryParse(Console.ReadLine(), out int number))
{
    if (number % 2 == 0)
    {
        Console.WriteLine($"Число {number} є ПАРНИМ.");
    }
    else
    {
        Console.WriteLine($"Число {number} є НЕПАРНИМ.");
    }
}
else
{
    Console.WriteLine("Помилка: введіть ціле число.");
}
