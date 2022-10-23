int num1 = InputNum("Введите первое число: ");
int num2 = InputNum("Введите второе число: ");

if(Pov(num1) == num2 || Pov(num2) == num1)
{
    Console.WriteLine("Одно число является квадратом другого");
}
else
{
    Console.WriteLine("Одно число не является квадратом другого");
}

int Pov(int a)
{
    return a * a;
}

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

