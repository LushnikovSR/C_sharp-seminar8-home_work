// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Console.Write("Задайте количество строк 2D массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов 2D массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] baseArray = Get2DArray(rows, columns, 1, 10);
Console.WriteLine();
PrintArray(baseArray);

SortRows2DArrayDescendingOrder(baseArray);
Console.WriteLine();
PrintArray(baseArray);

void SortRows2DArrayDescendingOrder(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int k = 0; k < inArray.GetLength(1) - 1; k++)
        {
            int max = inArray[i, k];
            int maxIndex1 = i;
            int maxIndex2 = k;
            for (int j = k + 1; j < inArray.GetLength(1); j++)
            {
                if (max < inArray[i, j])
                {
                    max = inArray[i, j];
                    maxIndex1 = i;
                    maxIndex2 = j;
                }
            }
            if (max != inArray[i, k])
            {
                int temporary = inArray[i, k];
                inArray[i, k] = inArray[maxIndex1, maxIndex2];
                inArray[maxIndex1, maxIndex2] = temporary;
            }
        }
    }
}

int[,] Get2DArray(int rowValue, int columnValue, int minValue, int maxValue)
{
    int[,] array = new int[rowValue, columnValue];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}