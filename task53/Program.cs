// task53 Задайте двумерный массив. Напишите программу, которая поменяет местами 
//первую и последнюю строку массива.Например, задан массив:1 4 7 2, 5 9 2 3,8 4 2 4
//получается  массив:8 4 2 4, 5 9 2 3, 1 4 7 2
void inputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


void SwapFirstLastString (int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int a = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = a;
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
inputMatrix(matrix);
SwapFirstLastString(matrix);