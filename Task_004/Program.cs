int[] numbers = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};

for (int a = 1; a < 21; a++)
{
    int b = a % 2;
    if (b == 0)
    {
        Console.WriteLine(a);
    }
    numbers[a] = numbers[a] + 1;
    
}