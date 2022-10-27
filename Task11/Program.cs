/*Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (x и y).*/

Console.Write("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());


if(num == 1)
{
    Console.Write("х и у > 0");
}
else if(num == 2)
{
    Console.Write("х < 0, y > 0");
}
else if(num == 3)
{
    Console.Write("x и y < 0");
}
else if(num == 4)
{
    Console.Write("х > 0, у < 0");
}
else
{
    Console.Write("Такой четверти нет");
}