/*
Задача 63: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"

Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"

Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9

Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

//задача 63
//Console.WriteLine(NaturalNumber(numA));

int NaturalNumber(int a)
{
    if(a == 1)
    {
        return 1;
    }
    else
    {
        Console.Write(NaturalNumber(a - 1) + " ");
    }
    return a;
}

// можно сделать черех void

//NaturalNumberVoid(numA);

void NaturalNumberVoid(int a)
{
    if(a == 1)
    Console.Write(a + " ");
    else
    {
        NaturalNumberVoid(a - 1); // если поменять местами NaturalNumber(a - 1); и Console.Write(a + " ");, то печать будет от большего к меньшему
        Console.Write(a + " ");
    }
}

//Задача 65

//Console.WriteLine(NaturalFromTo(numA, numB));

int NaturalFromTo(int a, int b)
{
    if(a == b)
    {
        return b;
    }
    else if(a < b)
    {
        Console.Write(NaturalFromTo(a, b - 1) + ", ");
    }
    else
    {
        Console.Write(NaturalFromTo(a, b + 1) + ", ");
    }
    return b;
}

//Задача 67

//Console.WriteLine(ReturnSumOfNumbers(numA));

int ReturnSumOfNumbers(int a)
{
    if(a > 0)
    {
        return a % 10 + ReturnSumOfNumbers(a / 10);
    }
    return 0;
}

//Задача 69

Console.WriteLine(GoNumToADegree(numA, numB));

int GoNumToADegree(int a, int b)
{
    if(b == 0)
    {
        return 1;
    }
    return a * GoNumToADegree(a, b - 1);
}