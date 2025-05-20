using System;

class Program
{
    static void Main()
    {
        Table table = new Table();

        Console.WriteLine("Прізвища:");
        foreach (string surname in table["прізвище"])
        {
            Console.WriteLine(surname);
        }

        Console.WriteLine("Кількість студентів з прізвищем Нечай: " + table.CountNechai);
    }
}

