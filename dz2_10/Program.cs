/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.*/
// метод (функция) ввода числа
int GetInt()
{
    Console.WriteLine("Введите трехзначное число: ");
    return int.Parse(Console.ReadLine());
}
// метод (функция) вычисления второй цифры и вывода второй цифры числа
void OutSecondDigit(int a)
{
    if ((a >= 100) && (a <= 999))
        Console.WriteLine((a - (a / 100) * 100) / 10);
    else
    {
        Console.WriteLine("Число не трехзначное");
    }

}

OutSecondDigit(GetInt());