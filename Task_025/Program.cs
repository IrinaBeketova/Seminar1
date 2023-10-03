// Задача 25: Напишите цикл, 
// который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Assistant (string note)
{
    Console.Write(note);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Root(int mainBase, int exponent)
{
    int root = 1;
    for (int i = 0; i < exponent; i++)
    {
        root *= mainBase;
    }
    return root;
}

bool Exponentiation (int exponent)
{
    if (exponent < 0)
    {
        Console.WriteLine("Показатель не должен быть отрицательным");
        return false;
    }
    return true;
}

int mainBase = Assistant("Введите основное число: ");
int exponent = Assistant("Введите показатель степени: ");
if (Exponentiation (exponent))
{
Console.WriteLine($"Число {mainBase} в степени {exponent} равно {Root(mainBase, exponent)}");
}