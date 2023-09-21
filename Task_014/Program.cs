// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

bool MultipleOfTwoNumbers (int num, int num1, int num2)
{
    return num % 7 == 0 && num % 23 ==0;
}

Console.WriteLine("Введите число");
int number = Convert.Toint32(Co)