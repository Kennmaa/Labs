using System;

public class RightTriangle
{
    public double FirstLeg { get; private set; }
    public double SecondLeg { get; private set; }

    public RightTriangle(double firstLeg, double secondLeg)
    {
        if (firstLeg <= 0 || secondLeg <= 0)
        {
            throw new ArgumentException("Катеты должны быть положительными числами.");
        }
        FirstLeg = firstLeg;
        SecondLeg = secondLeg;
    }
    public string GetInfo()
    {
        return $"Прямоугольный треугольник с катетами: {FirstLeg} и {SecondLeg}";
    }
    public double CalculateTangent()
    {
        return SecondLeg / FirstLeg;
    }
}
public class Program
{
    public static void Main()
    {
        try
        {
            RightTriangle triangle = new RightTriangle(3, 4);
            Console.WriteLine(triangle.GetInfo());
            double tangent = triangle.CalculateTangent();
            Console.WriteLine($"Тангенс угла, противолежащего второму катету: {tangent}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
