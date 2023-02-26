// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.Write("Задайте количество строк для первого 2D массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов для первого 2D массива: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Задайте количество строк для второго 2D массива: ");
int rows2Arr = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов для второго 2D массива: ");
int columns2Arr = int.Parse(Console.ReadLine());

int[,] firstArray = Get2DArray(rows, columns, 1, 10);
int[,] secondArray = Get2DArray(rows2Arr, columns2Arr, 1, 10);

Console.WriteLine();
PrintArray(firstArray);
Console.WriteLine();
PrintArray(secondArray);
if (CompareTwo2DArray(firstArray, secondArray))
{
    Console.WriteLine("Результат умножения матриц:");
    PrintArray(Multiplication2DArrays(firstArray, secondArray));
}
else Console.Write("Матрицы не соглавсованы, поэтому операция умножения невыполнима.");

int[,] Multiplication2DArrays(int[,] firstInArray, int[,] secondInArray)
{
    int[,] matrixA = firstInArray;
    int[,] matrixB = secondInArray;
    int sum = 0;

    if (firstInArray.GetLength(0) ==  secondInArray.GetLength(1))
    {
        matrixA = secondInArray;
        matrixB = firstInArray;
    }

    int[,] newArray = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int k = 0; k < matrixB.GetLength(1); k++)
    {
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixA.GetLength(1); j++)
            {
                sum += matrixA[i, j] * matrixB[j, k];
            }
            newArray[i, k] = sum;
            sum = 0;
        }
    }
    return newArray;
}

bool CompareTwo2DArray(int[,] firstInArray, int[,] secondInArray)
{
    return (firstInArray.GetLength(0) == secondInArray.GetLength(1) || firstInArray.GetLength(1) == secondInArray.GetLength(0));
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