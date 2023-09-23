// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Variable(string array)
{
    Console.Write(array);
    string toKnow = Console.ReadLine();
    int result = Convert.ToInt32(toKnow);
    return result;
}
int thirdDigit(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
bool Examination(int number)
{
    if (number < 100)
    {
      Console.WriteLine("Третьей цифры нет");
      return false;  
    }
    return true;
}
int number = Variable("Введите любое число > ");
if (Examination(number))
{
    Console.WriteLine(thirdDigit(number));
}
