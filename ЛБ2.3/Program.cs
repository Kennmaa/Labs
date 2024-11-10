Console.WriteLine("Введите стороны треугольника");
Console.Write("Введите сторону a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите сторону b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите сторону c: ");
double c = Convert.ToDouble(Console.ReadLine());
if (a == b || a == c || b == c)
{
    Console.WriteLine("Треугольник является равнобедренным.");
}
else
{
    Console.WriteLine("Треугольник не является равнобедренным.");
}