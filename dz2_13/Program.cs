/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. */

Console.WriteLine("Введите число: ");

string text = Console.ReadLine();
int i;
int length = text.Length;
if ((length > 2) && int.TryParse(text, out i))
{
    Console.WriteLine(text[2]);
}
else if ((length <= 2) && int.TryParse(text, out i))
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine("Неправильный ввод");
}
