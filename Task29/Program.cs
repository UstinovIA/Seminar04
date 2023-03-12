// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] CreateArray(int countElements, int min, int max)
{
    int[] collection = new int[countElements];
    Random rnd = new Random();
    for (int i = 0; i < countElements; i++)
    {
        collection[i] = rnd.Next(min, max);
    }
    return collection;
}

void PrintArray(int[] collection)
{
    Console.Write("[");
    for (int i = 0; i < collection.Length - 1; i++)
    {
        Console.Write($"{collection[i]}, ");
    }
    Console.Write($"{collection[collection.Length - 1]}]");
}

int[] array = CreateArray(8, 0, 100);
PrintArray(array);