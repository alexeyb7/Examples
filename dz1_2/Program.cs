int a;
int b;

Console.WriteLine("Введите чиcло а");
int.TryParse(Console.ReadLine(), out a);
Console.WriteLine("Введите число b");
int.TryParse(Console.ReadLine(), out b);

if (a > b)
{
    Console.Write("Максимальное число: ");
    Console.Write(a);
}
else if (a < b)
{
    Console.Write("Максимальное число: ");
    Console.Write(b);
}
else
{
    Console.WriteLine("a = b");
}
