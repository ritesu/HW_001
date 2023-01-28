Console.WriteLine("Введите до какого значения показать четные числа");
int a = int.Parse(Console.ReadLine()?? "0");
a = a + 1;
for (int i = 1; i < a; i++)
{
    int b = i % 2;
    if (b == 0)
    {
        Console.WriteLine(i);
    }
}