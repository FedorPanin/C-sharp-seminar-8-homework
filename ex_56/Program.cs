//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int rows = 5;
int cols = 4;
int[,] array = new int[rows, cols];

Random rand = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        array[i, j] = rand.Next(10);
    }
}
Console.WriteLine("Изначальный массив:");
PrintArray(array);

int minSum = int.MaxValue;
int minSumRowIndex = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    int rowSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        rowSum += array[i, j];
    }
    if (rowSum < minSum)
    {
        minSum = rowSum;
        minSumRowIndex = i;
    }
}

Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRowIndex}");

static void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write("{0,3} ", array[i, j]);
        }
        Console.WriteLine();
    }
}