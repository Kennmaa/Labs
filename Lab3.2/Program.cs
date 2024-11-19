Console.WriteLine("Введите значение x: ");
double x = double.Parse(Console.ReadLine());

Console.WriteLine("Введите точность вычислений : ");
double e = double.Parse(Console.ReadLine());

double sum = 0; // Переменная для хранения суммы
double term;    // Текущий член ряда
int k = 1;      // Счетчик членов ряда

do
{
    // Вычисляем текущий член ряда
    term = Math.Sin(k * x) / k;

    // Чередуем знаки
    if (k % 2 == 0)
        term = -term;

    // Добавляем текущий член к сумме
    sum += term;

    k++; // Переход к следующему члену ряда

} while (Math.Abs(term) > e); // Продолжаем, пока член ряда больше epsilon

Console.WriteLine($"Сумма ряда с точностью {e}: {sum}");