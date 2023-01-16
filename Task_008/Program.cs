Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine()?? "0");
while(a < 100 || a > 999)
{
    Console.WriteLine("Введено некорректное чило");
    a = int.Parse(Console.ReadLine()?? "0");
}
int b = a % 10;
int c = (a / 10) %10;
int d = a / 100;
int e = d * 10 + b;
Console.WriteLine(e);