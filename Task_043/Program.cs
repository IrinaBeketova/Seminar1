﻿﻿// задача 43. Напишите програму которая найдет точку пересечения
//двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1,k1, b2, k2 задаются пользователем.

Console.WriteLine("Введите переменную b1 : ");
double b1  = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
if (k1 != k2)
{
double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
Console.Write($"Точка пересечения двух прямых: [{x},{y}]");
}
else Console.WriteLine("Эти прямые параллельны");
