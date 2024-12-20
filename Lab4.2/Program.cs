int n = 3;
int m = 4;
int[,] A = new int[n, m];
for (int i = 0; i < n * m; i++)
{
    int s = i / m;
    int c = i % m;
    A[s, c] = s * c;
    Console.Write(A[s, c] + "\t");
    if (c == m - 1)
        Console.WriteLine();
}