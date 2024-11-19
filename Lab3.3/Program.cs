Console.WriteLine("Таблица значений");
for (double x = -1.5; x <= 1.5; x += 0.2)
{
    double y;

    if (x > 1)
    {
        y = 1 + Math.Sqrt(Math.Abs(Math.Cos(x)));
    }
    else
    {
        if (x < -0.5)
        {
            y = 1 - Math.Pow(x, 2);
        }
        else
        {
            y = x + 1;
        }
    }
    Console.WriteLine(String.Format("x = {0:f1};  y = {1:f3}", x, y));
}