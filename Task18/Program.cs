/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5


int size = 5;
int min = 1;
int max = 123;
int from = 10;
int until = 99;
int count = 0;

int[] array = new int [size];

FillArr(array);
PrintArr(array);
Console.WriteLine();

FindSegment(array);
Console.WriteLine($"В массиве {count} чисел от 10 до 99");

int FindSegment(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= from && arr[i] <= until)
        {
            count++;
        }
    }
    return count;
}

void FillArr(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
}

void PrintArr(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if(i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
}
*/

/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

Console.Write("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

int min = 1;
int max = 10;
int[] arr = new int[size];
int[] miltipl;

FillArr(arr);
PrintArr(arr);
Console.WriteLine();

if(arr.Length % 2 == 0)
{
    miltipl = new int[arr.Length / 2];
}
else
{
    miltipl = new int[arr.Length / 2 + 1];
    miltipl[miltipl.Length - 1] = arr[arr.Length / 2];
}

for(int i = 0; i < arr.Length / 2; i++)
{
    miltipl[i] = arr[i] * arr[arr.Length - 1 - i];
}

PrintArr(miltipl);

void FillArr(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
}

void PrintArr(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if(i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
}
