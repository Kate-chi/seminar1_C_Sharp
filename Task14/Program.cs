/*
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = 0;

for(int i = 1; i <= num; i++)
{
    result += i;
}

Console.Write($"Сумма чисел от 1 до {num} = {result}");
*/

/*
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int count = 1;

while(num1 > 9)
{
    num1 /= 10;

    count++;
}

Console.Write($"В вашем числе {count} цифр");


/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120


Console.Write("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int resul = 1;

for(int i = 1; i <= num2; i++)
{
    resul *= i;
}

Console.Write($"Произведение чисел от 1 до {num2} = {resul}");
*/