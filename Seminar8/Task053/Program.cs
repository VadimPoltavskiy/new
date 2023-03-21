int [,] array2d = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(array2d);
Console.WriteLine();
ReplacingRowsMatrix(array2d);
PrintMatrix(array2d);




int [,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)   //перебор строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //перебор столбцов
        {
            matrix [i,j] = rnd.Next(min, max+1);
        }
    }
    return matrix;
}

void ReplacingRowsMatrix (int [,] matrix)
{
            int num = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          num = matrix[matrix.GetLength(1)-1, j];
          matrix[matrix.GetLength(1)-1, j] = matrix[0,j];
          matrix[0,j] = num;
        }
}

void PrintMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             Console.Write($"{matrix[i, j], 3} ");
        }
        Console.WriteLine();
    }
}