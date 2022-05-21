// Task 62. Заполните спирально массив 4 на 4.
Console.Clear();
Console.WriteLine("This program fills array 4 x 4 with a spiral method.");
Console.WriteLine();
int numberRow = 4;
int numberCol = 4;
int[,] spiralArray = new int[numberRow, numberCol];
FillArraySpiral(spiralArray, numberRow, numberCol);
Console.WriteLine("This is spiral array:");
Console.WriteLine();
PrintArray(spiralArray);

int[,] FillArraySpiral(int[,] array, int numberRow, int numberCol)
{
    int counter = 1, i = 0, j = 0;
    while (counter <= numberRow * numberCol)
    {
        array[i, j] = counter;
        counter++;
        if (i <= j + 1 && i + j < numberCol - 1)
        {
            j++;
        }
        else if (i < j && i + j >= numberRow - 1)
        {
            i++;
        }
        else if (i >= j && i + j > numberCol - 1)
        {
            j--;
        }
        else
        {
            i--;
        }

    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}