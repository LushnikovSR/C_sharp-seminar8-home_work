// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.Write("Задайте количество строк 2D массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов 2D массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] baseArray = Get2DArray(rows, columns, 1, 10);
Console.WriteLine();
PrintArray(baseArray);

PrintRowNumberArrayMinSum(GetRowSumArray(baseArray));

void PrintRowNumberArrayMinSum(int[] inArray)
{
    int minValue = inArray[0];
    int minValIndex = 0;
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i] < minValue)
        {
            minValue = inArray[i];
            minValIndex = i;
        }
    }
    Console.Write($"Среди строк массива, наименьшая сумма элементов в: {minValIndex + 1} строке");
}

int[] GetRowSumArray(int[,] inArray)
{
    int[] sumArray = new int[inArray.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];
        }
        sumArray[i] = sum;
        sum = 0;
    }
    return sumArray;
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