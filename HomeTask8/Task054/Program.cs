int[,] matr= CreateMatrixRndInt (4, 8, -10, 10);
PrintMatrix(matr);
ArrangeInRowsMatrix(matr);
Console.WriteLine();
PrintMatrix(matr);


void ArrangeInRowsMatrix(int[,] matrix)
{
    for (int i = 0;  i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            int max=matrix[i,j];
            int maxindex=j;
            for (int k = j+1; k < matrix.GetLength(1); k++)
            {
             if (matrix[i,k] > max) 
                {
                    max=matrix[i,k];
                    maxindex = k;
                }
            }
            matrix[i, maxindex] = matrix[i,j];
            matrix[i,j]= max;
        }
    }
}

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