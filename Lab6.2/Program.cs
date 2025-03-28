using System;

class Program
{
    static void Main()
    {
        int[,] mas = new int[7, 7];
        Random random = new Random();

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                mas[i, j] = random.Next(1, 100);
                Console.Write(mas[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int min = 0, max = 0;
        for (int i = 1; i < 7; i++)
        {
            if (mas[i, i] < mas[min, min]) min = i;
            if (mas[i, i] > mas[max, max]) max = i;
        }

        int temp = mas[min, min];
        mas[min, min] = mas[max, max];
        mas[max, max] = temp;

        Console.WriteLine("\nМатрица после замены:");
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                Console.Write(mas[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"\nМинимум: {temp} (был на [{min},{min}])");
        Console.WriteLine($"Максимум: {mas[min, min]} (был на [{max},{max}])");
    }
}