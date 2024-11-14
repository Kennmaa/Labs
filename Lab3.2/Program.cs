Console.WriteLine("Введите значение n:");
int n;
if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
{
    Console.WriteLine("Ошибка");
    return;
}

double Q = 0; //сумма 

for (int k = 1; k <= n; k++)
{
    double y = Math.Pow(-1, k) * (k - 7); // Числитель
    double d = 2 * (n - k);             // Знаменатель
    if (d == 0 || double.IsInfinity(n / d)) // Пропуск слагаемых
        continue;
    Q += n / d;
}
Console.WriteLine("Сумма ряда Q: " + Q);