/*
Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
1, 2, 3
4, 6, 1
2, 1, 6

1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза


Задача 59: Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
*/

int rows = InputNum("введите количество строк: ");
int columns = InputNum("введите количество столбцов: ");
int min = 1;
int max = 9;

int[,] array = new int[rows, columns];

Fill2DArrRandomNum(array);
Print2DArr(array);
Console.WriteLine();

int minI = 0;
int minJ = 0;
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        if(array[i, j] < array[minI, minJ])
        {
            minI = i;
            minJ = j;
        }
    }
}

int[,] newArr = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
int newArrRowIndex = 0;
int newArrColIndex = 0;

for(int i = 0; i < array.GetLength(0); i++)
{
    if(i == minI)
        continue;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        if(j == minJ)
            continue;
        else
        {
            newArr[newArrRowIndex, newArrColIndex] = array[i, j];
        }
        newArrColIndex++;
    }
    newArrColIndex = 0;
    newArrRowIndex++;
}

Print2DArr(newArr);

/*
Sort2DArray(array);
Print2DArr(array);
Console.WriteLine();

int[,] dictionary = AmountDictionary(array);

for (int i = 0; i < dictionary.GetLength(0); i++)
    {
        Console.WriteLine($"{dictionary[i, 0]} встречается {dictionary[i, 1]}");
    }

int[,] AmountDictionary(int[,] arr)
{
    int size = CalculateUniqueNumbers(arr);
    int[,] dictionary = new int[size, 2];
    int dictionaryIndex = 0;
    dictionary[dictionaryIndex, 0] = arr[0, 0];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if(dictionary[dictionaryIndex, 0] == arr[i, j])
            {
                dictionary[dictionaryIndex, 1]++;
            }
            else
            {
                dictionaryIndex++;
                dictionary[dictionaryIndex, 0] = arr[i, j];
                dictionary[dictionaryIndex, 1] = 1;
            }
        }
    }
    return dictionary;
}

int CalculateUniqueNumbers(int[,] sortArr)
{
    int count = 1;
    int tempNum = sortArr[0, 0];
    for(int i = 0; i < sortArr.GetLength(0); i++)
    {
        for(int j = 0; j < sortArr.GetLength(1); j++)
        {
            if(tempNum != sortArr[i, j])
            {
                tempNum = sortArr[i, j];
                count++;
            }
        }
    }
    return count;
}

void Sort2DArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            for(int a = 0; a < arr.GetLength(0); a++)
            {
                for(int b = 0; b < arr.GetLength(1); b++)
                {
                    if(arr[a, b] < arr[i, j])
                    {
                        int temp = arr[a, b];
                        arr[a, b] = arr[i, j];
                        arr[i, j] = temp;
                    }
                }
            }
        }
    }
}
*/

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
