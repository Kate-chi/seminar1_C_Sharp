//Задайте двумерный массив M x N, заполненный случайными целыми числами

int min = 1;
int max = 9;
int row = 3;
int col = 5;

int[,] array2D = new int[row, col]; 

// можно указать определенные значения: {{1, 2, 3, 4, 5}, {6, 7, 8, 9, 10}, {9, 8, 7, 6, 5}}
// можно узнать размерность массива (количество строк - измерений): Console.WriteLine(array2D.Rank);
// можно узнать количество элементов в массиве: Console.WriteLine(array2D.Lenght); (в данном случае - 15)
// можно узнать количество строк и колонок: Console.WriteLine(array2D.GetLenght(0)); Выведет 3
                                            //Console.WriteLine(array2D.GetLenght(1)); Выведет 5 

for(int i = 0; i < row; i++)
{
    for(int j = 0; j < col; j++)
    {
        Console.Write($"{array2D[i, j] = new Random().Next(min, max + 1)} ");
    }
    Console.WriteLine();
}


