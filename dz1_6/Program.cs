int a;

Console.WriteLine("Введите число: ");
int.TryParse(Console.ReadLine(), out a);

if (a % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}