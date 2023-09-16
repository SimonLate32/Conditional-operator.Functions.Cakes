using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите цену первого торта (P1): ");
        int p1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество первого торта в наличии (N1): ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите цену второго торта (P2): ");
        int p2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество второго торта в наличии (N2): ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите доступную сумму (M): ");
        int m = int.Parse(Console.ReadLine());

        int maxTorts = 0;

        for (int i = 0; i <= n1; i++)
        {
            for (int j = 0; j <= n2; j++)
            {
                if (i * p1 + j * p2 <= m && (i + j) > maxTorts && i > 0 && j > 0)
                {
                    maxTorts = i + j;
                }
            }
        }

        if (maxTorts < 2)
        {
            Console.WriteLine("Невозможно купить хотя бы по одному торту каждого вида.");
        }
        else
        {
            Console.WriteLine($"Максимальное количество тортов разных видов: {maxTorts}");
        }
    }
}
