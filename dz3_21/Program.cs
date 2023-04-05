/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */



double Magic(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)), 3);
}

double C = Magic(x1, y1, z1, x2, y2, z2);
System.Console.WriteLine($"Длина отрезка - {C}");