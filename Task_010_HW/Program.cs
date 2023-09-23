// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000);
Console.WriteLine($"Трёхзначное число -> {number}");
int twoDigitNumber = number / 10;
int secondDigit = twoDigitNumber % 10;
Console.WriteLine(secondDigit);
