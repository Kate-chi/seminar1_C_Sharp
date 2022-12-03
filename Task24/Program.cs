/*
Задача 53: Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива.

Задача 55: Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/

int rows = InputNum("введите количество строк: ");
int columns = InputNum("введите количество столбцов: ");
int min = 1;
int max = 9;

int[,] array = new int[rows, columns];
int[,] reverseArray = new int[columns, rows];

Fill2DArrRandomNum(array);
Print2DArr(array);
Console.WriteLine();

SwapRowsToColumns(array, reverseArray);
Print2DArr(reverseArray);

void SwapRowsToColumns(int[,] arr, int[,] revArr)
{
    for(int i = 0; i < revArr.GetLength(0); i++)
    {
        for(int j = 0; j < revArr.GetLength(1); j++)
        {
            revArr[i, j] = arr[j, i];
        }
    }
}

void SwapRows(int[,] arr)
{
    int firstRow = 0;
    int lastRow = arr.GetLength(0) - 1;
    for(int i = 0; i < arr.GetLength(1); i++)
    {
        int temp = arr[firstRow, i];
        arr[firstRow, i] = arr[lastRow, i];
        arr[lastRow, i] = temp;
    }
}

void Fill2DArrRandomNum(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void Print2DArr(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}