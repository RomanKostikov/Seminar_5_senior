// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Main()
{
    Console.Clear();

    Console.WriteLine("Enter size array:");
    int num = int.Parse(Console.ReadLine()!);

    double[] ourArray = FillArray(num);
    double max1 = FindMax(ourArray);
    double min1 = FindMin(ourArray);
    Console.WriteLine($"Max number = {max1}, min number = {min1}");
    Console.WriteLine($"Difference between maximum and minimum number = {Math.Round((max1 - min1), 2)}");
}
double[] FillArray(int size)
{
    double[] arr = new double[size];
    Console.WriteLine("Array:");
    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
        Console.Write($"{arr[i]} ");
    }

    return arr;
}
double FindMax(double[] arr)
{
    double max = Int32.MinValue;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}
double FindMin(double[] arr)
{
    double min = Int32.MaxValue;

    for (int i = 0; i < arr.Length; i++)
    {

        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

Main();