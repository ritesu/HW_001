﻿Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()?? "0");
if (a < 100)
{
    Console.WriteLine("Третьего числа нет");
}
else if (a >= 100 && a < 1000)
{
    int b = a % 10;
    Console.WriteLine("Третье число равно");
    Console.WriteLine(b);
}
else if (a >= 1000 && a < 10000)
{
    int c = (a / 10) % 10;
    Console.WriteLine("Третье число равно");
    Console.WriteLine(c);
}
else if (a >= 10000 && a < 100000)
{
    int d = (a / 100) % 10;
    Console.WriteLine("Третье число равно");
    Console.WriteLine(d);
}
else if (a >= 100000 && a < 1000000)
{
    int e = (a / 1000) % 10;
    Console.WriteLine("Третье число равно");
    Console.WriteLine(e);
}
else if (a >= 1000000 && a < 10000000)
{
    int f = (a / 10000) % 10;
    Console.WriteLine("Третье число равно");
    Console.WriteLine(f);
}
else if (a >= 10000000 && a < 100000000)
{
    int g = (a / 100000) % 10;
    Console.WriteLine("Третье число равно");
    Console.WriteLine(g);
}
else if (a >= 100000000 && a < 1000000000)
{
    int h = (a / 1000000) % 10;
    Console.WriteLine("Третье число равно");
    Console.WriteLine(h);
}
else if (a >= 1000000000 && a < 10000000000)
{
    int i = (a / 10000000) % 10;
    Console.WriteLine("Третье число равно");
    Console.WriteLine(i);
}
else if (a >= 10000000000 && a < 100000000000)
{
    int j = (a / 100000000) % 10;
    Console.WriteLine("Третье число равно");
    Console.WriteLine(j);
}