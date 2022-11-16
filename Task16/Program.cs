/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

int size = 12;
int min = -9;
int max = 9;
int[] array = new int [size];
int negativSum = 0;
int positivSum = 0;

PrintArr(array);
Console.WriteLine();
FillArr(array);
PrintArr(array);
Console.WriteLine();


for(int i = 0; i < array.Length; i++)
{
    if(array[i] < 0)
    {
        negativSum += array[i];
    }
    else
    {
        positivSum += array[i];
    }
}

Console.Write($"Сумма отрицательных чисел = {negativSum}, сумма положительных чисел = {positivSum}");


void FillArr(int[] arr)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

void PrintArr(int[] arr)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(arr[i]);

        if(i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
}
