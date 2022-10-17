Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if((num1 * num1) == num2)
{
    Console.Write("Второе число является квадратом первого! :)");
}
else
{
    Console.Write("Второе число не является квадратом первого! :(");
}