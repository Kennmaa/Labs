try
{
    Console.WriteLine("Введите стороны прямоугольника");
    Console.WriteLine("Введите сторону a");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите сторону b");
    int b = int.Parse(Console.ReadLine());
    int S = a * b;
    int P = (a + b) * 2;
    Console.WriteLine($"Периметр равен {P}");
    Console.WriteLine($"Площадь равен {S}");
}
catch 
{
    Console.Write("Введите правильно");
}
