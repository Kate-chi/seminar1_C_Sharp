/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= num; i++)
{
    Console.Write(i * i);
    if(i < num)
    {
        Console.Write(", ");
    }
}
