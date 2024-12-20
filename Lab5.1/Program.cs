Console.WriteLine("Введите символы первого массива:");
string array1 = Console.ReadLine();

Console.WriteLine("Введите символы второго массива:");
string array2 = Console.ReadLine();

Console.WriteLine("Общие символы:");
foreach (char c in array1)
{
    if (array2.Contains(c))
    {
        Console.WriteLine(c);
    }
}