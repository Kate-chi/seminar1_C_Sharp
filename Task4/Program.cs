Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(99 < num && num < 1000)
{
    Console.Write("Последняя цифра вашего числа - " + (num % 10));
}
else
{
    Console.Write("Упс, вы ввели неверное число :( ");
}
