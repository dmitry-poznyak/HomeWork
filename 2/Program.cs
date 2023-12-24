// Задача 2: Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.

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

void SwapRows(int[,] array, int rowI1, int rowI2)
{
    int cols = array.GetLength(1);
    for (int j = 0; j < cols; j++)
    {
        int temp = array[rowI1, j];
        array[rowI1, j] = array[rowI2, j];
        array[rowI2, j] = temp;
    }
}




int[,] myArray = Construct2DArray(5,5,0,9);
Print2DArray(myArray);
System.Console.WriteLine();
SwapRows(myArray, 0, myArray.GetLength(0) - 1);
Print2DArray(myArray);

