// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
Console.Write("Задайте размерность 2D массива: ");
int rowsColumns = int.Parse(Console.ReadLine());

// int[,] baseArray = GetSpiralFilledArray(rowsColumns);
// Console.WriteLine();
// PrintArray(baseArray);

GetSpiralFilledArray(rowsColumns);

bool ChooseSpinDirection(string direction)
{
    if (direction == "l") return (false);
    return (true); // if (direction == "l") 
}

string IntConvert2DigitNumber(int number) // преобразует натуральное (однознаковое) число в двухзнаковую строку
{
    string strNum = String.Empty;
    if (number > 9) return number.ToString();
    else return "0" + number.ToString();
}

void GetSpiralFilledArray(int sizeArray) // int[] startPoint, string spinDirection
{
    string[,] array = new string[sizeArray, sizeArray];
    int count = 1;
    string printValue = String.Empty;
    ChooseSpinDirection("r");

    for (int i = 0; i < sizeArray; i++) // движение по часовой стрелке, точка входа правый верхний угол
    {   // точкf входа (0,8)
        for (int j = i / 2; j < sizeArray - (i / 2) - (i % 2); j++) // 
        {
            if (i % 2 == 0)
            {
                array[j, sizeArray - i / 2 - 1] = IntConvert2DigitNumber(count); // движение вниз       0
            }
            else array[sizeArray - j - 2, i / 2] = IntConvert2DigitNumber(count); // движение вверх         1
            count++;
        }
        for (int k = (i / 2) + (i % 2); k < sizeArray - (i / 2) - 1; k++) // 
        {
            if (i % 2 == 0)
            {
                array[sizeArray - i / 2 - 1, sizeArray - k - 2] = IntConvert2DigitNumber(count); // движение влево    0
            }
            else array[i / 2, k] = IntConvert2DigitNumber(count); // движение вправо            1
            count++;
        }
        PrintArray(array);
        Console.WriteLine("-----------");
    }
    // return array;
}


void PrintArray(string[,] inArray)
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
