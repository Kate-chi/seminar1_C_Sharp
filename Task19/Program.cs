/*
Напишите программу, которая переворачивает одномерный массив(первый элемент станет последним, а последний первым и т.д)

1 2 3 4 5 - 5 4 3 2 1
*/

Console.Write("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

int min = 1;
int max = 10;
int[] array = new int[size];

FillArr(array);
PrintArr(array);
Console.WriteLine();

SwapArr(array);
PrintArr(array);

void SwapArr(int[] arr)
{
    for(int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
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