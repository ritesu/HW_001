Console.WriteLine("Введите делимое");
double a = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите делитель");
double b = double.Parse(Console.ReadLine() ?? "0");
double c = a % b;
if (c == 0)
{
    Console.WriteLine("Делится нацело");
}
else
{
    Console.WriteLine("Нацело не делится");
    Console.WriteLine("Остаток равен");
    Console.WriteLine(c);
}