Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine());
double z = 0;
int k;
for (k = 1; k <= n; k++)
{
    int l = 1;
    for (int g = 2; g <= n - k; ++g)
    {
        l = l * g;
    }
    z += Math.Pow(-1, k) * (k - 7) / (2 * l);
}
Console.WriteLine(z);
