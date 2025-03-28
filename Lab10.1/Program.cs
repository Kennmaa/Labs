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

    // Метод для вычисления угла A (противолежащего первому катету) в градусах
    public double GetAngleA()
    {
        return Math.Atan(FirstLeg / SecondLeg) * (180 / Math.PI);
    }

    // Метод для вычисления угла B (противолежащего второму катету) в градусах
    public double GetAngleB()
    {
        return Math.Atan(SecondLeg / FirstLeg) * (180 / Math.PI);
    }

    // Метод для вычисления разности углов A и B
    public double GetAngleDifference()
    {
        return Math.Abs(GetAngleA() - GetAngleB());
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

            double angleA = triangle.GetAngleA();
            double angleB = triangle.GetAngleB();
            double angleDifference = triangle.GetAngleDifference();

            Console.WriteLine($"Угол A (противолежащий катету {triangle.FirstLeg}): {angleA}°");
            Console.WriteLine($"Угол B (противолежащий катету {triangle.SecondLeg}): {angleB}°");
            Console.WriteLine($"Разность углов A и B: {angleDifference}°");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
