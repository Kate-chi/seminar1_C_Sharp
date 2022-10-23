Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int remainder = num1 % num2;

if(remainder == 0)
{
    Console.Write($"{num1} кратно {num2}");
}
else
{
    Console.Write($"Остаток от деления {num1} на {num2} = {remainder}");
}