Console.WriteLine("Введите значения x: ");
double x = Convert.ToDouble(Console.ReadLine());
if (x != 1)
{
    double y = 3 / (x - 1);
    Console.WriteLine("Значение функции: " + y);
}
else
{
    Console.WriteLine("Функция не определена для x = " + x);
}

