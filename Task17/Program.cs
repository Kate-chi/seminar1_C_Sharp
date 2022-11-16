/*
Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]


int size = 5;
int min = -9;
int max = 9;
int[] arr = new int[size];

FillArr(arr);
PrintArr(arr);
Console.WriteLine();

ChangeSign(arr);
PrintArr(arr);


void ChangeSign(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
            array[i] = -array[i];
    }
}

void FillArr(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
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
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/

int[] array = {1, 2, 3, 45, 67, 89};
string find = "Нет";

PrintArr(array);
Console.WriteLine();

Console.Write("Введите искомое число: ");
int num = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < array.Length; i++)
{
    if(array[i] == num)
    {
        find = "Да";
        break;
    }
}

Console.Write(find);

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

