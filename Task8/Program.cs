Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int firstDivider = 7;
int secondDivider = 23;

if(IsMultiply(num, firstDivider) && IsMultiply(num, secondDivider))
{
    Console.WriteLine($"{num} кратно 7 и 23");
}
else
{
    Console.WriteLine($"{num} не кратно 7 и 23");
}

bool IsMultiply(int a, int div)
{
    return a % div == 0;
}
