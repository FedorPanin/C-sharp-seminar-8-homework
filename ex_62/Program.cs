// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.


Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, n];
int value = 1;
int top = 0, bottom = n - 1, left = 0, right = n - 1;

while (value <= n * n)
{
    for (int i = left; i <= right; i++)
    {
        array[top, i] = value;
        value++;
    }
    top++;

    for (int i = top; i <= bottom; i++)
    {
        array[i, right] = value;
        value++;
    }
    right--;

    for (int i = right; i >= left; i--)
    {
        array[bottom, i] = value;
        value++;
    }
    bottom--;

    for (int i = bottom; i >= top; i--)
    {
        array[i, left] = value;
        value++;
    }
    left++;
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("{0,3}", array[i, j]);
    }
    Console.WriteLine();
}