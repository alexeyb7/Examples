/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

task(Read());

int Read()
{
    Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

void task(int N)
{
    int result = 1;


    for (int i = 1; i <= N; i++)
    {

        result = i * i * i;
        Console.Write($"{result} ");
    }

}