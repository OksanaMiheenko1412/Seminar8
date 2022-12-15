// task55 Задайте двумерный массив. Напишите программу, которая заменяет строки на
// столбцы. В случае, если это невозможно, программа должна вывести сообщение для
// пользователя.Например, задан массив:1 4 7 2, 5 9 2 3, 8 4 2 4, 5 2 6 7
// получается массив:1 5 8 5, 4 9 4 2, 7 2 2 6, 2 3 4 7

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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {       
            if (i < j)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }

}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (coord[0] != coord[1])
{
    Console.Write("Вы ошиблись!\nВведите размеры матрицы: ");
    coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[coord[0], coord[1]];
Console.WriteLine("Начальный массив: ");
inputMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Конечный массив: ");
SwapFirstLastString(matrix);
