// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
Console.Write("Задайте количество строк 3D массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов 3D массива: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Задайте количество страниц 3D массива: ");
int pages = int.Parse(Console.ReadLine());

if (Check2DigitNumberCondition(rows, columns, pages))
{
    Console.Write("Двухзначных чисел не хватит чтобы заполнить массив выбранного размера.");
}
else
{
    int[,,] baseArray = Get3DArray(rows, columns, pages, 10, 100);
    Console.WriteLine();
    Print3DArray(baseArray);


}

bool Check2DigitNumberCondition(int rowValue, int columnValue, int pageValue)
{
    int quantity2DigitNumbers = 90;
    return (rowValue * columnValue * pageValue > quantity2DigitNumbers);
}

int[,,] Get3DArray(int rowValue, int columnValue, int pageValue, int minValue, int maxValue)
{
    int[,,] array = new int[rowValue, columnValue, pageValue];
    int count = 10;
    for (int p = 0; p < array.GetLength(2); p++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j, p] = count;
                count++;
            }
        }
    }
    return array;
}

void Print3DArray(int[,,] inArray)
{
    for (int p = 0; p < inArray.GetLength(2); p++)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Console.Write($"{inArray[i, j, p]}({i}, {j}, {p}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"page {p + 1}");
    }
}