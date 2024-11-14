Console.WriteLine("Выберите набор чисел (1, 2 или 3):");
int x = int.Parse(Console.ReadLine());
double y;
switch (x)
{
    case 1:
        {
            double a = 3;
            double b = 3.5;
            double c = -2.1;
            y = (a + b + c) / 3; 
            Console.WriteLine("Среднее значение 1: " + y);
            break;
        }
    case 2:
        {
            double a = 2.1;
            double b = -6.55;
            double c = 0.1;
            y = (a + b + c) / 3;
            Console.WriteLine("Среднее значение 2: " + y);
            break;
        }
    case 3:
        {
            double a = -9;
            double b = -3.7;
            double c = -0.1;
            y = (a + b + c) / 3;
            Console.WriteLine("Среднее значение 3: " + y);
            break;
        }
    default:
        Console.WriteLine("Неверный выбор. Выберите 1, 2 или 3.");
        break;
}
