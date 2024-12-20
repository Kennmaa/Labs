Console.WriteLine("Введите строку:");
string i = Console.ReadLine();

int A = 0;

foreach (char c in i)
{
    if (c == 'А' || c == 'а')
    {
        A++;
    }
}
Console.WriteLine($"Количество русских букв 'А' в строке: {A}");
