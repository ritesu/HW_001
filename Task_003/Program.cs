Console.WriteLine("Проверка числа на четность");
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()?? "0");
int b = a % 2;
if (b == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число является не четным");
}