Console.WriteLine("Введите значения x: ");
double x = Convert.ToDouble(Console.ReadLine());
double f = 1e-10;
if (Math.Abs(Math.Cos(x)) > f)
{
    double y = 2 * Math.Tan(x);
    Console.WriteLine("Значение функции: " + y);
}
else
{
    Console.WriteLine("Функция не определена для x = " + x);
}