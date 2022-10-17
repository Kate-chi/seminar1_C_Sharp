Console.Write("Введите номер дня недели (от 1 до 7): ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());

if(dayOfWeek == 1)
{
    Console.Write("Ваш день недели - понедельник!");
}
else if(dayOfWeek == 2)
{
    Console.Write("Ваш день недели - вторник!");
}
else if(dayOfWeek == 3)
{
    Console.Write("Ваш день недели - среда!");
}
else if(dayOfWeek == 4)
{
    Console.Write("Ваш день недели - четверг!");
}
else if(dayOfWeek == 5)
{
    Console.Write("Ваш день недели - пятница!");
}
else if(dayOfWeek == 6)
{
    Console.Write("Ваш день недели - суббота!");
}
else if(dayOfWeek == 7)
{
    Console.Write("Ваш день недели - воскресенье!");
}
else
{
    Console.Write("Очень жаль, Вы ввели неверный номер :(");
}
