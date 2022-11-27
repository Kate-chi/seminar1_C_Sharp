/*
Задайте двумерный массив. 
Найдите элементы, у который оба индекса нечетные и замените эти элементы на их квадраты

1 2 3           1 2 3
1 2 3   станет  1 4 3
1 2 3           1 2 3
*/

int rows = InputNum("введите количество строк: ");
int columns = InputNum("введите количество столбцов: ");
int min = 1;
int max = 9;

int[,] array = new int[rows, columns];

Fill2DArrRandomNum(array);
Print2DArr(array);
Console.WriteLine();

SquareUnevenIndex(array);
Print2DArr(array);

void SquareUnevenIndex(int[,] arr)
{
    for(int i = 1; i < arr.GetLength(0); i+=2)
    {
        for(int j = 1; j < arr.GetLength(1); j+=2)
        {
            arr[i, j] *= arr[i, j];
        }
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



/*
Задайте двумерный массив. 
Найдите сумму элементов, находящихся на главной диагонали: [0, 0], [1, 1] и тд

1 4 7 2
5 9 2 3
8 4 2 4

1 + 9 + 2 = 12


int rows = InputNum("введите количество строк: ");
int columns = InputNum("введите количество столбцов: ");

int[,] array = new int[rows, columns];

Fill2DArrRandomNum(array);
Print2DArr(array);
Console.WriteLine();

Console.Write($"Сумма элементов главной диагонали = {SumHeadDiagonal(array)}");

int SumHeadDiagonal(int [,] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if(i == j)
            {
                sum += arr[i, j];
                break; // чтоб не проверять числа после найденой диагонали
            }
        }
    }
    return sum;
}
*/