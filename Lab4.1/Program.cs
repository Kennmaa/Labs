int[,] mas1 = new int[2, 4];
Random random = new Random();
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 4; j++)
    {
        mas1[i,j] = (int)random.Next(10,100);
        Console.Write(mas1[i,j] + " ");
    }
    Console.WriteLine();
}
