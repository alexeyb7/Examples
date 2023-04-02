/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.*/
int GetInt()
{
    Console.WriteLine("Введите цифру дня недели: ");
    return int.Parse(Console.ReadLine());
}

int day = GetInt();

switch (day)
{
    case (6):
        Console.WriteLine("Суббота. Выходной день");
        break;
    case (7):
        Console.WriteLine("Воскресенье. Выходной день");
        break;
    case (1):
        Console.WriteLine("Понедельник. Рабочий день");
        break;
    case (2):
        Console.WriteLine("Вторник. Рабочий день");
        break;
    case (3):
        Console.WriteLine("Среда. Рабочий день");
        break;
    case (4):
        Console.WriteLine("Четверг. Рабочий день");
        break;
    case (5):
        Console.WriteLine("Пятника. Рабочий день");
        break;
    default:
        Console.WriteLine("Неправильный ввод");
        break;
}
