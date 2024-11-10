try
{
    Console.WriteLine("Введите трехзначное число ");
    int n = int.Parse(Console.ReadLine());
    int a = n/100;
    int b = n % 100/10;
    int c = n % 10;
    Console.Write(a*100+c*10+b);

}
catch 
{
    Console.Write("Введите правильно");
}

