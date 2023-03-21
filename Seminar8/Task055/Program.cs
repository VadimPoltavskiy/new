int [,] array2d = CreateMatrixRndInt(4, 6, -10, 10);
PrintMatrix(array2d);
Console.WriteLine();
//if (array2d.GetLength(0)==array2d.GetLength(1))
//{
    int [,] array2d2 = CreateMatrix(array2d);
    PrintMatrix(array2d2);
//}
//else
//{
//   Console.WriteLine("ERROR: задана несимметричная матрица");
//}

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

int [,] CreateMatrix(int [,] matrix)
{
    int[,] matrix2 = new int[matrix.GetLength(1), matrix.GetLength(0)];
  
    for (int i = 0; i < matrix2.GetLength(0); i++)   //перебор строк
    {
        for (int j = 0; j < matrix2.GetLength(1); j++) //перебор столбцов
        {
            matrix2 [i,j] = matrix[j,i];
        }
    }
    return matrix2;
}