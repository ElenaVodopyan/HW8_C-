// Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел (размер массива не более 50 элементов). Напишите программу, которая будет построчно выводить массив.
int[,] FillArray(int rowSize, int colSize)
{
    int[,] numbers = new int[rowSize, colSize];
    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < colSize; j++)
        {
            int value = new Random().Next(10, 100);
            while (Contains(numbers, value))
            {
                value = new Random().Next(10, 100);
            }
            numbers[i, j] = value;
        }
    }
    return numbers;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(string.Format("{0} ", array[i, j]));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

bool Contains(int[,] arr, int value)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == value) return true;
        }
    }
    return false;
}

Console.WriteLine("Задайте размер массива (m,n):");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
if (m * n <= 50)
{
    int[,] nums1 = FillArray(m, n);
    ShowArray(nums1);
}
else Console.WriteLine("Максимальный размер массива 50 элементов");