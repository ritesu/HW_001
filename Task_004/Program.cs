int[] numbers = Enumerable.Range(1, 101).ToArray();

for (int a = 1; a < numbers.Length; a++)
{
    int b = a % 2;
    if (b == 0)
    {
        Console.WriteLine(a);
    }
    numbers[a] = numbers[a] + 1;
    
}