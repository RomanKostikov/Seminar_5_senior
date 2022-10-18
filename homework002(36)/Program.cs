// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Main()
{
    Console.Clear();

    Console.WriteLine("Enter size array:");
    int num = int.Parse(Console.ReadLine()!);

    int[] ourArray = FillArray(num);
    int sum1 = SumNumber(ourArray);
    Console.WriteLine($"\nSum of items in odd positions:");
    Console.WriteLine($"{sum1}");
}
int[] FillArray(int size)
{
    int[] arr = new int[size];
    Console.WriteLine("Array:");
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(size * -1, size);
        Console.Write($"{arr[i]} ");
    }

    return arr;
}
int SumNumber(int[] arr)
{
    int sum = 0;

    for (int i = 1; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

Main();