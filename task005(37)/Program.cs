// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void Main()
{
    Console.Clear();

    Console.WriteLine("Введите размер массива");
    int num = int.Parse(Console.ReadLine()!);

    int[] ourArray = FillArray(num, 1, 10);
    MuliplyElArray(ourArray);
}

int[] FillArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    Console.WriteLine("Cтарый массив");
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{arr[i]} ");
    }

    return arr;
}

void MuliplyElArray(int[] arr)
{
    int count = 0;


    if (arr.Length % 2 == 0)
    {
        count = arr.Length / 2;

    }
    else
    {
        count = arr.Length / 2 + 1;

    }
    int[] newArray = new int[count];

    // Console.WriteLine($"\nдлина нового массива {count}");
    Console.WriteLine("\nНовый массив");

    for (int i = 0; i < count; i++)
    {

        if (i == ((arr.Length - 1) - i))
        {
            newArray[i] = arr[i];
        }
        else
        {

            newArray[i] = arr[i] * arr[(arr.Length - 1) - i];
        }
        Console.Write($"{newArray[i]} ");

    }


}

Main();