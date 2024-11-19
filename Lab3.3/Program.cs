Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double s = 0;
int ind = 1;
for (int i = 1; i < n + 1; i++)
{
    s += ind * Math.Sin(i * x) / i;
    ind *= -1;
}
Console.WriteLine("Полученое значение суммы при x = " + x + " равно " + s);