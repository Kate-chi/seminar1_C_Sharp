/*
Напишите программу, которая принимает на вход 3 числа и проверяет, может ли существовать треугольник со сторонами такой длины
(Каждая сторона треугольника меньше суммы двух других сторон)


int firstNum = InputNum("Введите первое число: ");
int secondNum = InputNum("Введите второе число: ");
int thirdNum = InputNum("Введите третье число: ");

if(firstNum < secondNum + thirdNum && secondNum < firstNum + thirdNum && thirdNum < firstNum + secondNum)
{
    Console.Write("Из ваших чисел получился бы треугольник");
}
else
{
    Console.Write("Из ваших чисел треугольника бы не вышло");
}

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/
/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное
45 - 101101
3 - 11
2 - 10



int num = InputNum("Введите десятичное число: ");
string result = string.Empty;

while(num > 0)
{
    result = num % 2 + result;
    num /= 2;
}

Console.Write($"Число {num} в десятичной системе = {result}");

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/

/*
Не используя рекурсию, выведите первые N чисел Фибоначчи
Следующий элемент сумма двух предыдущих
5 - 0 1 1 2 3
7 - 0 1 1 2 3 5 8


int size = InputNum("Введите количество чисел Фибоначчи: ");
int[] array = new int[size];
int firstNum = 0;
int secondNum = 1;

for(int i = 0; i < array.Length; i++)
{
    array[i] = firstNum;
    firstNum = secondNum;
    secondNum = array[i] + firstNum;
}

PrintArr(array);

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

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/

/*
Напишите программу, которая будет создавать кописю заданного массива с помощью поэлементного копирования
*/

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 1;
int max = 10;

int[] array = new int[size];
int[] newArr = new int[size];

FillArr(array);
PrintArr(array);
Console.WriteLine();

CopyArr(newArr);
PrintArr(newArr);

void CopyArr(int [] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = array[i];
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
