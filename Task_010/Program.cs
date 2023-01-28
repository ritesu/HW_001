Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()?? "0");
string num = a.ToString();
int[] numbers = new int[num.Length];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = int.Parse(num[i].ToString());
}
if (a < 100)
{
    Console.WriteLine("Третьего числа нет");
}
for (int i = 0; i < numbers.Length; i++)
{
    if (i == 2)
    {
        Console.WriteLine("Третье число данного числа равна {0}", numbers[i]);
    }
}