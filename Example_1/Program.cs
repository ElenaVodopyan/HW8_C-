//  Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] FillArray(int rowSize, int colSize)
{
    int[,] numbers = new int[rowSize, colSize];
    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < colSize; j++)
            numbers[i, j] = new Random().Next(0, 10);
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
}

void ShowMinRow(int[,] array)
{
    int min = 1000;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ += array[i, j];
        }
        if (summ < min)
        {
            index = i; 
            min = summ;
        }
    }
    Console.Write($"Номер строки с наименьшей суммой элементов: {index + 1} строка");
}


int[,] nums2 = FillArray(3, 4);
ShowArray(nums2);
ShowMinRow(nums2);
