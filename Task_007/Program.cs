int[] numbers = Enumerable.Range(10, 100).ToArray();
int max = 0;
for (int a = 10; a < numbers.Length; a++)
{
    int b = numbers[a] / 10;
    if (b > 0)
    {
        if (a > max)
        {
            max = a;
        }
        numbers[a] = numbers[a] + 1;
    }
}

Console.WriteLine("Максимальное число");
Console.Write(max);