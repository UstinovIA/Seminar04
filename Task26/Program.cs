// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int countDigit = CountDigit(num);
Console.WriteLine($"В числе {num} содержится {countDigit} цифр(ы)");

int CountDigit(int number)
{
    int quantityDigit = 0;
    do
    {
        number /= 10; //number = number / 10
        quantityDigit++;
    } while (number != 0);
    return quantityDigit;
}