int[,] arr2d =CreateMatrixRndInt (4,4,0,10);
PrintMatrix(arr2d);
Console.WriteLine();
var indexesMin= MinElement(arr2d);
int [,] newArr2d =DeliteRowColumnMatrix(arr2d, indexesMin.Row, indexesMin.Column);
PrintMatrix(newArr2d);



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

(int Row, int Column) MinElement(int [,] matrix)
{
    int indexRow= 0;
    int indexColumn= 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          if (matrix [indexRow, indexColumn] > matrix [i,j])
          {
            indexRow=i;
            indexColumn=j;
          }  
        }
    }
    return (indexRow, indexColumn);
}

int [,] DeliteRowColumnMatrix(int [,] matrix, int row, int column)
{
    int [,] newMatrix = new int [matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    int n =0; int m=0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (m == row) m++;
        for (int j = 0; j < newMatrix.GetLength(0); j++)
        {
            if (n== column) n++;
            newMatrix[i,j]= matrix[m, n];
            n++;

        }
        m++;
        n = 0;
    }
    return newMatrix;
}