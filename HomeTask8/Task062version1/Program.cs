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
    int i=0;
    int j=0;
   do
   {
        while (j < matrix.GetLength(1) && matrix[i,j]==0)
        {
           matrix[i,j] = sequenceNumber;
           sequenceNumber++;
           j++;
        }
        j--;
        i++;
        while (i < matrix.GetLength(0) && matrix[i,j]==0)
        {
           matrix[i,j] = sequenceNumber;
           sequenceNumber++;
           i++;
        }
        i--;
        j--;
        while (j >= 0 && matrix[i,j]==0)
        {
           matrix[i,j] = sequenceNumber;
           sequenceNumber++;
           j--;
        }
        j++;
        i--;
        while (i >= 0 && matrix[i,j]==0)
        {
           matrix[i,j] = sequenceNumber;
           sequenceNumber++;
           i--;
        }
        i++;
        j++;
    } while (sequenceNumber <= rows * columns);
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



