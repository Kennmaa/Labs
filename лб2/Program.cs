try
{
    Console.WriteLine("Введите переменнаю");
    double x = double.Parse(Console.ReadLine());
    double y = 3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7;
    Console.Write($"y={y:N2}");
}
catch
{
    Console.Write("Введите правильно");
}