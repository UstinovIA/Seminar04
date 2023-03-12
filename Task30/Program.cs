// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    Random rnd = new Random();
    while (index < length)
    {
        collection[index] = Convert.ToInt32(Math.Round(rnd.NextDouble(), 0));
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($" {col[position]} ");
        position++;
    }
}

int[] array = new int[8];

FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine();