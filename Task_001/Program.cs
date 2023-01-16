Console.WriteLine("Является ли первое число квадратом второго?");
Console.WriteLine("Введите первое число");
double a = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число");
double b = double.Parse(Console.ReadLine() ?? "0");
double c = b / a;
if (c == a)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}