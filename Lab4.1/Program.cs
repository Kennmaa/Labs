Random random = new Random();
int[] array = new int[8];
int[] result = new int[8];

for (int i = 0; i < 8; i++)
{
    array[i] = random.Next(10, 100);
    result[i] = array[i] % 10;
}
Console.WriteLine(string.Join(" ", result));

