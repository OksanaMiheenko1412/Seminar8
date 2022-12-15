// task57 Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент
// входных данных.{ 1, 9, 9, 0, 2, 8, 0, 9 } 0 встречается 2 раза,1 встречается 1 раз,
//2 встречается 1 раз,8 встречается 1 раз,9 встречается 3 раза

bool checkElement(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
            return false;
    }
    return true;
}

int inputMatrix(int[,] matrix, int[] array)
{
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            if (checkElement(array, matrix[i, j]))
            {
                array[k] = matrix[i, j];
                k++;
            }
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    return k;
}


void SwapFirstLastString (int[,] matrix, int[] array, int countArray)
{
    int count = 0;
    for (int k = 0; k < countArray; k++)
    {
        count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {       
                if (array[k] == matrix[i, j])
                    count++;
            }
        }
        Console.WriteLine($"Элемент {array[k]} встречается {count} раз");
    }

}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
int[] array = new int[coord[0] * coord[1]];
Console.WriteLine("Начальный массив: ");
int countArray = inputMatrix(matrix, array);
Console.WriteLine();
Console.WriteLine($"[{string.Join(", ", array)}]");
SwapFirstLastString(matrix, array, countArray);
