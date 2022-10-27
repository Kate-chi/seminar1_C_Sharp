/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

int ax = InputNum("Введите координаты точки А через enter: ");
int ay = Convert.ToInt32(Console.ReadLine());

int bx = InputNum("Введите координаты точки B через enter: ");
int by = Convert.ToInt32(Console.ReadLine());

int firstLeg = ax - bx;
int secondLeg = ay - by;

double distance = Math.Sqrt((firstLeg * firstLeg) + (secondLeg * secondLeg));

Console.Write($"Расстояние между задаными точками = {distance}");

int InputNum(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
