Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine()?? "0");
while(a < 100 || a > 999)
{
    Console.WriteLine("Введено некорректное чило");
    a = int.Parse(Console.ReadLine()?? "0");
}
int b = a / 10;
int c = b % 10;
Console.WriteLine("Вторая цифра трехзначного числа");
Console.Write(c);