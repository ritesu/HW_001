int[] numbers = Enumerable.Range(0, 100).ToArray();

for (int a = 1; a < 101; a++)
{
    int b = a % 2;
    if (b == 0)
    {
        Console.WriteLine(a);
    }
    numbers[a] = numbers[a] + 1;
    
}