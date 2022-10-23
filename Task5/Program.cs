int randomNum = new Random().Next(10, 100);
Console.WriteLine(randomNum);

int firstNum = randomNum / 10;
int secondNum = randomNum % 10;

Console.Write($"Наибольшая цифра числа: {FindMax(firstNum, secondNum)}");

int FindMax(int num1, int num2)
{
    if(num1 > num2)
    {
        return num1;
    }
    else
    {
        return num2;
    }
}
