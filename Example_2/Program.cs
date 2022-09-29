//  Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.
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
    Console.WriteLine();
}

int[,] MultiplyArrays(int[,] up, int[,] down)
{
    int[,] result = new int[up.GetLength(0), down.GetLength(1)];
    for (int i = 0; i < up.GetLength(0); i++)
    {
        for (int j = 0; j < down.GetLength(1); j++)
        {
            int summ = 0;
            for (int k = 0; k < up.GetLength(0); k++)
            {
                summ += up[i, k] * down[k, j];
            }
            result[i, j] = summ;
        }
    }
    return result;
}

int[,] nums1 = FillArray(3, 3);
int[,] nums2 = FillArray(3, 3);
ShowArray(nums1);
ShowArray(nums2);
ShowArray(MultiplyArrays(nums1, nums2));
