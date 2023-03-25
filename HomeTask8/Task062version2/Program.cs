Console.Write("Введите количество строк: ");
int rowsMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columnsMatrix = Convert.ToInt32(Console.ReadLine());

int[,] matr1= AssigningValuesSpiralMatrix (rowsMatrix, columnsMatrix);
PrintMatrix(matr1);


int [,] AssigningValuesSpiralMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int sequenceNumber = 1;
    int numberOfCircles = rows > columns ? columns/2 : rows/2;
    for (int k = 0; k <= numberOfCircles; k++)
    {
    
        for (int j = 0 + k; j < matrix.GetLength(1) - k; j++)
        {
           int i = 0 + k;
            matrix [i,j] =sequenceNumber;
            sequenceNumber++;
        }
        for (int i = 1 + k; i < matrix.GetLength(0) - k; i++)
        {
            int j = matrix.GetLength(1)-1-k;
            matrix [i,j] = matrix [i,j] == 0 ? sequenceNumber : matrix [i,j];
            sequenceNumber++;
        }
        for (int j = matrix.GetLength(1)-1-1-k; j >= 0 + k; j--) 
        {
            int i = matrix.GetLength(0)-1-k;
            matrix [i,j] = matrix [i,j] == 0 ? sequenceNumber : matrix [i,j];
            sequenceNumber++;
        }
        for (int i = matrix.GetLength(0)-1-1-k; i >= 1 + k; i--)
        {
            int j = 0 + k;
            matrix [i,j] = matrix [i,j] == 0 ? sequenceNumber: matrix [i,j];
            sequenceNumber++;
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
             Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine();
    }
}



