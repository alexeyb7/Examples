/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.*/

Console.WriteLine("Введите пятизначное число");
string str = Console.ReadLine();
int length = str.Length;

if (length == 5)
    if (str[0] == str[4] && str[1] == str[3])
        Console.WriteLine($"Число {str} - палиндром");
    else
        Console.WriteLine($"Число {str} - не палиндром");
else
    Console.WriteLine("Неправильный ввод");