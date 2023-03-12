// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Pow(int numberA, int numberB)
{
    if (numberB < 0) return -1;
    if (numberB == 0) return 1;
    int originalNumber = numberA;
    while (numberB != 1)
    {
        numberA *= originalNumber;
        numberB--;
    }
    return numberA;
}

Console.Write("Введите число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральную степень: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
int result = Pow(firstNum, secondNum);
string output = result < 0 ? "Вы ввели не натуральную степень" : $"{firstNum}^{secondNum}={result}";
Console.WriteLine(output);