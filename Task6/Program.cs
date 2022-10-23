int randomNum = new Random().Next(100, 1000);

int num1 = randomNum / 100;
int num3 = randomNum % 10;

Console.WriteLine($"{randomNum} без второй цифры = {num1}{num3}");