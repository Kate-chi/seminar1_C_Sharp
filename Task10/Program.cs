/*
Напишите программу, которая принимает на вход координаты точки (X и Y),
 причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
 в которой находится эта точка.
*/

int x = InputNum("Введите координаты Х: ");
int y = InputNum("Введите координаты Y: ");

if(x == 0 || y == 0)
{
    Console.WriteLine("Упс, вы ввели неправильное число :( ");
    return;
}

if(x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой четверти");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во второй четверти");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей четверти");
}
else if(x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвертой четверти");
}

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
