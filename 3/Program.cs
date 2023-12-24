// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.


int[,] Construct2DArray(int rows, int colums, int min, int max)
{
    int[,] array = new int [rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int FindMinSumRow(int[,] array)
{
    int minSum = int.MaxValue;
    int minSumRowIndex = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int currentSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            currentSum += array[i, j];
        }
        if (currentSum < minSum)
        {
            minSum = currentSum;
            minSumRowIndex = i;
        }
    }
    return minSumRowIndex;
}

int[,] myArray = Construct2DArray(3,6,0,9);
Print2DArray(myArray);
System.Console.WriteLine(FindMinSumRow(myArray));


