int a;
int b;
int c;

Console.WriteLine("Введите чиcло а");
int.TryParse(Console.ReadLine(), out a);
Console.WriteLine("Введите число b");
int.TryParse(Console.ReadLine(), out b);
Console.WriteLine("Введите число c");
int.TryParse(Console.ReadLine(), out c);
// функция Max
int Max(int a, int b, int c)
{
    int result = a;
    if (b > result) result = b;
    if (c > result) result = c;
    return result;
}


Console.WriteLine("Максимальное число:");
Console.WriteLine(Max(a, b, c));


