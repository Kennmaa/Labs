Console.WriteLine("Введите w ");
double w = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение y:");
double y = Convert.ToDouble(Console.ReadLine());
if (w < 0 || y < 0 || y + 3.5 <= 0)
{
    Console.WriteLine("Ошибка: ");
    return;
}
double q = 9.33 * Math.Pow(w, 3) + Math.Sqrt(w); // числитель
double n = Math.Log(y + 3.5) + Math.Sqrt(y); // знаменатель
double G = q / y;
Console.WriteLine($"G: {G}");
