﻿// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите любое число");
int Number = Convert.ToInt32(Console.ReadLine());
int lastDigit = Number % 2;
if (lastDigit == 0)
{
    Console.WriteLine($"да");
}
else
{
    Console.WriteLine($"нет");
}