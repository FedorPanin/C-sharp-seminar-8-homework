//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] array = new int[5, 5];
Random rnd = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        array[i, j] = rnd.Next(100);
    }
}

Console.WriteLine("Исходный массив:");
PrintArray(array);

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 4; j++)
    {
        for (int k = j + 1; k < 5; k++)
        {
            if (array[i, j] < array[i, k])
            {
                int temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
        }
    }
}

Console.WriteLine("Массив после упорядочивания каждой строки по убыванию:");
PrintArray(array);

static void PrintArray(int[,] array)
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}