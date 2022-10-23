int num1 = InputNum("Введите первое число: ");
int num2 = InputNum("Введите второе число: ");

int remainder = num1 % num2;

if(remainder == 0)
{
    Console.Write($"{num1} кратно {num2}");
}
else
{
    Console.Write($"Остаток от деления {num1} на {num2} = {remainder}");
}

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
