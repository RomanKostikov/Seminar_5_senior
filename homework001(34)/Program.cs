// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Main()
{
    Console.Clear();

    Console.WriteLine("Enter size array:");
    int num = int.Parse(Console.ReadLine()!);

    int[] ourArray = FillArray(num, 100, 1000);
    int count = CountNumber(ourArray);
    Console.WriteLine($"\nNumber of even numbers:");
    Console.WriteLine($"{count}");
}
int[] FillArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    Console.WriteLine("Array:");
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{arr[i]} ");
    }

    return arr;
}
int CountNumber(int[] arr)
{
    int coun = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int num = arr[i];
        if (num % 2 == 0)
        {
            coun++;
        }
    }
    return coun;
}
Main();